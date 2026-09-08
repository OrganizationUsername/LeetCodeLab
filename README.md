# LeetCodeLab

LeetCode as a failing unit test suite. Open the solution in Visual Studio, look at Test
Explorer, pick a red test, make it green. No browser, no login, no network — and you get
breakpoints, the watch window, and the profiler, which the website does not give you.

56 problems, 161 test cases. 18 Easy / 35 Medium / 3 Hard.

## Quick start

```
dotnet test --project practice/LeetCodeLab.Practice   # 150 red, 1 green
```

Or just open `LeetCodeLab.sln` in Visual Studio and hit Test Explorer.

The one green test in the practice project is `CoverageTests`, which fails only if a case
file in `data/` has no matching problem class.

## The loop

1. In Test Explorer, group by Traits and filter to what you feel like — `Difficulty=Easy`,
   `Topic=Dynamic Programming`, or `Problem=146` for one problem.
2. Pick a red row. Each row is one test case, named after its input:
   `1. Two Sum #2: [[3,2,4],6]`.
3. Open the stub, delete the `throw new NotImplementedException();`, write the solution.
4. Re-run. Failures read like `result: expected [0,1] but got [1,0]`, with the input echoed.

From the CLI:

```
dotnet test --project practice/LeetCodeLab.Practice --filter-trait "Difficulty=Easy"
dotnet test --project practice/LeetCodeLab.Practice --filter-trait "Topic=Sliding Window"
dotnet test --project practice/LeetCodeLab.Practice --filter-trait "Problem=42"
```

## Layout

```
data/                        56 case files - the single source of truth
src/LeetCodeLab.Core/        ListNode, TreeNode, and their LeetCode-format builders
src/LeetCodeLab.Harness/     argument binding, comparison modes, design driver, xUnit glue
practice/LeetCodeLab.Practice/   the stubs you fill in            <- you work here
verify/LeetCodeLab.Verify/       reference solutions + harness tests
```

`verify` exists because the case files are hand-written, and hand-written expectations are
worth exactly nothing until something proves them. Every case file has a known-good
solution behind it, so `dotnet test --project verify/LeetCodeLab.Verify` going green means
the expectations the practice stubs are judged against are correct. It caught two real bugs
while this was being built. **It also contains full solutions to every problem, so don't go
looking in there unless you mean to.**

## Why there is a harness at all

LeetCode is not uniformly "assert equal", which is why you can't just write `Assert.Equal`
and call it a day. The harness handles:

| Mode | Meaning | Example |
| --- | --- | --- |
| `Exact` | deep structural equality | most problems |
| `Unordered` | flat sequence, order irrelevant | Two Sum, Permutations |
| `UnorderedNested` | sequence of sequences, neither order matters | 3Sum, Subsets |
| `FloatTolerance` | numeric within 1e-5 | running medians |
| `InPlacePrefix` | returns `k`; only the first `k` mutated elements count | Remove Duplicates |
| `MutatedArg` | the answer is the mutated argument, not the return | Move Zeroes, Reorder List |
| `AnyValid` | several answers accepted; a `Validate` method judges | Longest Palindromic Substring |
| `Design` | constructor + method-call sequence against a stateful object | LRU Cache, Trie |

Arguments bind by **your method signature**, not by a type hint in the data. The same JSON
`[1,2,3]` becomes an `int[]`, a `ListNode`, or a `TreeNode` depending on what your method
asks for, so you can write the natural C# signature and the harness adapts.

## Time and memory limits

Every case runs on a dedicated worker thread with a wall-clock budget (5 s by default,
`timeoutMs` per problem or per case) and an optional `maxAllocatedBytes` cap. Blowing
either fails the test with a specific message rather than hanging the run.

A timer alone would be theatre, though: an O(n²) Two Sum finishes instantly on
`[2,7,11,15]`. So eleven problems also carry a **stress case** with a large generated
input, sized so the intended complexity passes comfortably and the naive approach cannot:

| Problem | Input | Traps |
| --- | --- | --- |
| 3, 42, 53, 121, 128, 215, 217 | 200k elements | O(n²) scans |
| 300 Longest Increasing Subsequence | 100k elements | O(n²) DP |
| 139 Word Break | 1000 `a`s | exponential recursion |
| 322 Coin Change | amount 100000 | unmemoised recursion |
| 875 Koko Eating Bananas | speeds to 1e9 | linear search over the answer |

Only the *recipe* lives in the data file, so a 200k-element array costs one line:

```json
{ "name": "stress: 200k distinct",
  "args": [{ "$gen": "permutation", "seed": 7, "count": 200000 }],
  "expected": false }
```

Generators (`ints`, `sortedInts`, `permutation`, `repeatedChar`, `randomString`) run on a
fixed xorshift32, deliberately not `System.Random` — that algorithm changed between .NET
versions and the expected answers are baked into the data files.

Two caveats worth knowing:

- **Allocation, not peak memory.** The cap measures bytes allocated on the solution's
  thread, which catches "built an O(n²) table" but is not a resident-set limit. A real RSS
  ceiling needs a separate process; this is the useful 90%.
- **A timed-out thread keeps running.** .NET removed `Thread.Abort` with no safe
  replacement, so a genuine infinite loop is reported correctly but burns one core until
  the process exits.

## Adding a problem

Drop a file in `data/`, named `<4-digit id>-<slug>.json`:

```json
{
  "id": 704, "slug": "binary-search", "title": "Binary Search",
  "difficulty": "Easy", "topics": ["Array", "Binary Search"],
  "url": "https://leetcode.com/problems/binary-search/",
  "comparison": "Exact",
  "cases": [
    { "args": [[-1,0,3,5,9,12], 9], "expected": 4 },
    { "args": [[-1,0,3,5,9,12], 2], "expected": -1 }
  ]
}
```

Then add the stub. Two attributes and a base class is the whole contract:

```csharp
[Problem(704)]
public sealed class BinarySearch : ProblemTests<BinarySearch>
{
    public int Solve(int[] nums, int target)
    {
        throw new NotImplementedException();
    }
}
```

The class needs exactly one public instance method; mark it `[Solution]` if you want more
than one. Design problems point at the class under test instead:

```csharp
[Problem(146, Target = typeof(LRUCache))]
public sealed class LruCacheTests : ProblemTests<LruCacheTests>;
```

Op names in the data are matched case-insensitively, so LeetCode's `put` finds your `Put`.

Linked-list cycle problems take a `cyclePos` on the case, which splices the tail back into
the list before the call — LeetCode passes that as a separate input rather than in the list.

## What this does not do

**These are the published example cases plus hand-written stress cases, not LeetCode's
judge suite.** The hidden tests are not available anywhere, so green here means your logic
handles the examples, the edge cases in the data, and — on the eleven problems that have
one — a large input. It does not mean you would get "Accepted": the other 45 problems have
no timing pressure, and nothing here checks for integer overflow on adversarial inputs.

What it does catch is the errors you actually make while learning, in a debugger, offline.

Problem statements are not included — the case files carry the `url`, so read the statement
on leetcode.com. That keeps this repo clear of their content.

## Requirements

.NET 10 SDK. `global.json` opts `dotnet test` into Microsoft.Testing.Platform, which is what
xUnit v3 runs on; without it the .NET 10 SDK tries the retired VSTest path and errors out.
