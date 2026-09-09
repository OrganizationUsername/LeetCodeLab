# LeetCodeLab

LeetCode as a failing unit test suite. Open the solution in Visual Studio, look at Test
Explorer, pick a red test, make it green. No browser, no login, no network — and you get
breakpoints, the watch window and the profiler, which the website does not give you.

**132 problems, 401 test cases.** 51 Easy / 75 Medium / 6 Hard, across 18 topics.

Every problem carries its own description, constraints, worked examples and graded hints,
so you never need the website open. And every problem is provably solvable: each one has a
reference solution that passes its cases (see [Verification](#verification)).

## Quick start

```
dotnet test --project practice/LeetCodeLab.Practice   # 401 red, 1 green
```

Or open `LeetCodeLab.sln` in Visual Studio and use Test Explorer.

The single green test is `CoverageTests`, which fails only if a case file has no stub.

## What a problem looks like

```csharp
namespace LeetCodeLab.Practice.Problems.Arrays;

// ============================================================================
//  1. Two Sum                                                           [Easy]
//  https://leetcode.com/problems/two-sum/
// ----------------------------------------------------------------------------
//  Find the two entries of nums that add up to target and return their
//  positions. Exactly one pair works, you may not use the same element twice,
//  and either order is accepted.
//
//  Examples
//    nums = [2,7,11,15], target = 9  ->  [0,1]
//    nums = [3,2,4], target = 6  ->  [1,2]
//
//  Constraints
//    2 <= nums.Length <= 10^4
//    exactly one valid answer exists
//
//  Hints (read only as many as you need)
//    1. The obvious double loop is O(n^2). What is it recomputing?
//    2. While scanning, for each x you want to know whether target - x has
//       already appeared.
//    3. A Dictionary from value to index answers that in O(1). Store as you
//       go, so you never match an element with itself.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(1)]
public sealed class TwoSum : ProblemTests<TwoSum>
{
    public int[] Solve(int[] nums, int target)
    {
        throw new NotImplementedException();
    }
}
```

The hints are deliberately graded — the first is a nudge, the last is close to the answer.
Take the fewest you can. Descriptions are written from scratch rather than copied from
LeetCode, so this repo carries none of their content; the `url` is there when you want the
original wording.

The worked examples are generated from the actual case data, so they can never drift out of
sync with what the test asserts.

## The loop

1. In Test Explorer, group by Traits and filter to what you feel like: `Difficulty=Easy`,
   `Topic=Dynamic Programming`, or `Problem=146` for one problem.
2. Pick a red row. Each row is one case, named after its input:
   `1. Two Sum #2: [[3,2,4],6]`.
3. Delete the `throw new NotImplementedException();` and write the solution.
4. Re-run. Failures read `result: expected [0,1] but got [1,0]`, with the input echoed.

```
dotnet test --project practice/LeetCodeLab.Practice --filter-trait "Difficulty=Easy"
dotnet test --project practice/LeetCodeLab.Practice --filter-trait "Topic=Sliding Window"
dotnet test --project practice/LeetCodeLab.Practice --filter-trait "Problem=42"
```

## Coverage

| Folder | # | Folder | # | Folder | # |
| --- | --- | --- | --- | --- | --- |
| Arrays | 20 | Graphs | 7 | Matrix | 3 |
| DynamicProgramming | 18 | Searching | 7 | Heap | 3 |
| Trees | 17 | Design | 7 | Intervals | 3 |
| LinkedLists | 11 | SlidingWindow | 6 | BitManipulation | 2 |
| TwoPointers | 8 | Numbers | 5 | Greedy | 2 |
| Backtracking | 7 | Stacks | 4 | Strings | 2 |

## Layout

```
data/                            132 case files - the single source of truth
src/LeetCodeLab.Core/            ListNode, TreeNode, deterministic input generators
src/LeetCodeLab.Harness/         argument binding, comparison modes, execution guard
tools/Scaffold/                  renders practice stubs from the case files
practice/LeetCodeLab.Practice/   the stubs you fill in            <- you work here
verify/LeetCodeLab.Verify/       reference solutions + harness tests
```

## Verification

The case files are hand-written, and hand-written expectations are worth nothing until
something proves them. So every problem has a reference solution in `verify/`, and

```
dotnet test --project verify/LeetCodeLab.Verify      # 422 tests, all green
```

going green means the expectations you are judged against are correct. It caught three real
bugs while this was built: empty `ListNode`/`TreeNode` canonicalising to `null` instead of
`[]`, a `PriorityQueue` used with a constant priority, and a folder named `Math` shadowing
`System.Math`.

**`verify/` contains full solutions to every problem. Stay out of it unless you mean to.**

## Why there is a harness at all

LeetCode is not uniformly "assert equal", which is why you cannot just write `Assert.Equal`:

| Mode | # | Meaning | Example |
| --- | --- | --- | --- |
| `Exact` | 97 | deep structural equality | most problems |
| `MutatedArg` | 8 | the answer is the mutated argument, not the return | Move Zeroes, Rotate Image |
| `Unordered` | 7 | flat sequence, order irrelevant | Two Sum, Permutations |
| `Design` | 7 | constructor + method-call sequence on a stateful object | LRU Cache, Trie |
| `UnorderedNested` | 5 | sequence of sequences, neither order matters | 3Sum, Subsets |
| `AnyValid` | 4 | several answers accepted; a `Validate` method judges | Find Peak Element |
| `FloatTolerance` | 2 | numeric within 1e-5 | Pow(x, n) |
| `InPlacePrefix` | 2 | returns `k`; only the first `k` mutated elements count | Remove Duplicates |

Arguments bind by **your method signature**, not by a type hint in the data. The same JSON
`[1,2,3]` becomes an `int[]`, a `ListNode` or a `TreeNode` depending on what your method
asks for, so you write the natural C# signature and the harness adapts.

## Time and memory limits

Every case runs on a dedicated worker thread with a wall-clock budget (5 s by default,
`timeoutMs` per problem or per case) and an optional `maxAllocatedBytes` cap. Blowing either
fails the test with a specific message rather than hanging the run.

A timer alone would be theatre, though: an O(n²) Two Sum finishes instantly on
`[2,7,11,15]`. So twelve problems also carry a **stress case** with a large generated input,
sized so the intended complexity passes comfortably and the naive approach cannot:

| Problem | Input | Traps |
| --- | --- | --- |
| 3, 42, 53, 55, 121, 128, 215, 217 | 200k elements | O(n²) scans |
| 300 Longest Increasing Subsequence | 100k elements | O(n²) DP |
| 139 Word Break | 1000 `a`s | exponential recursion |
| 322 Coin Change | amount 100000 | unmemoised recursion |
| 875 Koko Eating Bananas | speeds to 1e9 | linear search over the answer |

Only the *recipe* lives in the data file, so a 200k array costs one line:

```json
{ "name": "stress: 200k distinct",
  "args": [{ "$gen": "permutation", "seed": 7, "count": 200000 }],
  "expected": false }
```

Generators (`ints`, `sortedInts`, `permutation`, `repeatedChar`, `randomString`) run on a
fixed xorshift32, deliberately not `System.Random` — that algorithm changed between .NET
versions and the expected answers are baked into the data files.

Two caveats:

- **Allocation, not peak memory.** The cap measures bytes allocated on the solution's
  thread, which catches "built an O(n²) table" but is not a resident-set limit.
- **A timed-out thread keeps running.** .NET removed `Thread.Abort` with no safe
  replacement, so an infinite loop is reported correctly but burns one core until exit.

## Adding a problem

Drop a file in `data/` named `<4-digit id>-<slug>.json`, then run the scaffolder:

```
dotnet run --project tools/Scaffold
```

It writes the stub, description and all, and **never touches a stub that already exists** —
that is where your solutions are. Pass `--force` only if you mean to regenerate everything.

```json
{
  "id": 704, "slug": "binary-search", "title": "Binary Search",
  "difficulty": "Easy", "topics": ["Array", "Binary Search"],
  "url": "https://leetcode.com/problems/binary-search/",
  "comparison": "Exact",
  "folder": "Searching", "className": "BinarySearch",
  "signature": "int Solve(int[] nums, int target)",
  "statement": "Plain binary search on a sorted ascending array...",
  "constraints": ["1 <= nums.Length <= 10^4"],
  "hints": ["Two inclusive bounds, and loop while lo <= hi."],
  "complexity": "O(log n) time, O(1) space",
  "cases": [
    { "args": [[-1,0,3,5,9,12], 9], "expected": 4 },
    { "args": [[-1,0,3,5,9,12], 2], "expected": -1 }
  ]
}
```

The class needs exactly one public instance method; mark it `[Solution]` if you want more
than one. Design problems declare their shape instead:

```json
"design": { "type": "LRUCache",
            "members": ["LRUCache(int capacity)", "int Get(int key)",
                        "void Put(int key, int value)"] }
```

Op names in the data are matched case-insensitively, so LeetCode's `put` finds your `Put`.

One rule when choosing `folder`: it becomes a namespace segment, so **do not name it after a
BCL type**. A folder called `Math` makes `Math.Abs` resolve to the namespace and fail to
compile, which is why the folders here are `Numbers`, `Stacks` and `LinkedLists`.

## What this does not do

**These are the published example cases plus hand-written stress cases, not LeetCode's judge
suite.** The hidden tests are not available anywhere, so green here means your logic handles
the examples, the edge cases in the data, and — on the twelve problems that have one — a
large input. It does not mean you would get "Accepted": the other 120 problems have no
timing pressure, and nothing here checks for integer overflow on adversarial inputs.

What it does catch is the errors you actually make while learning, in a debugger, offline.

## Requirements

.NET 10 SDK. `global.json` opts `dotnet test` into Microsoft.Testing.Platform, which is what
xUnit v3 runs on; without it the .NET 10 SDK tries the retired VSTest path and errors out.
