# LeetCodeLab

LeetCode as a failing unit test suite. Open the solution in Visual Studio, look at Test
Explorer, pick a red test, make it green. No browser, no login, no network — and you get
breakpoints, the watch window and the profiler, which the website does not give you.

**215 problems, 1559 test cases.** 65 Easy / 137 Medium / 13 Hard, across 31 topics.

18 of them are original engineering problems with no LeetCode page, where the point is to
work the solution out rather than recall it — see [Original problems](#original-problems).

Every problem carries its own description, constraints, worked examples and graded hints,
so you never need the website open. And every problem is provably solvable: each one has a
reference solution that passes its cases (see [Verification](#verification)).

## Quick start

```
dotnet test --project practice/LeetCodeLab.Practice   # 1559 red, 1 green
```

Or open `LeetCodeLab.slnx` in Visual Studio and use Test Explorer. That is the XML solution
format, which needs Visual Studio 17.13 or newer; there is no classic `.sln` here.

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

### Printing things while you work

`Console.WriteLine` is not much use here. It is captured, but it arrives unattributed in a
single lump at the end of the run, so with hundreds of cases going you cannot tell which
one printed what. Use the ambient output helper instead:

```csharp
TestContext.Current.TestOutputHelper?.WriteLine($"lo={lo} hi={hi} mid={mid}");
```

It needs no constructor plumbing, and it works from inside `Solve` even though the harness
invokes that by reflection on its own worker thread. The text appears under **Standard
output** in the report for the exact case that failed. `Xunit` is in the practice project's
global usings, so no `using` line is needed in the stub.

The command line only prints this for failing tests, which suits the red-to-green loop. A
`Debug.WriteLine` plus a breakpoint is still the better tool when you want to inspect a
passing case.

## Coverage

| Folder | # | Folder | # | Folder | # |
| --- | --- | --- | --- | --- | --- |
| Arrays | 20 | Backtracking | 7 | PrefixSums | 3 |
| DynamicProgramming | 18 | Design | 7 | UnionFind | 3 |
| Trees | 17 | Greedy | 7 | Fabrication | 2 |
| Graphs | 13 | Searching | 7 | Layout | 2 |
| Matrix | 12 | Strings | 7 | LoadCases | 2 |
| LinkedLists | 11 | SlidingWindow | 6 | Parsing | 2 |
| Stacks | 9 | Tries | 6 | PlaneGeometry | 2 |
| BitManipulation | 8 | Numbers | 5 | SectionProperties | 2 |
| Heap | 8 | MeshTopology | 4 | Simulation | 2 |
| Intervals | 8 | Numerics | 4 | | |
| TwoPointers | 8 | MonotonicStack | 3 | | |

## Original problems

The 18 problems numbered 9001 and up are not from LeetCode. They have no published
solution to half-remember, which is the point: you have to derive the approach. They are
posed in structural-engineering terms, but each one is carrying an ordinary computer
science idea underneath.

```
dotnet test --project practice/LeetCodeLab.Practice --filter-trait "Topic=Original"
```

| Folder | Problems | The idea underneath |
| --- | --- | --- |
| SectionProperties | polygon area and centroid, built-up inertia | one-pass accumulation, signed area |
| MeshTopology | free edges, node merging, bandwidth, load path | hashing normalised keys, union-find, BFS, brute-force search |
| LoadCases | combination envelopes, axle train reactions | per-element extrema, optimising over a continuum by finding the finite candidate set |
| Numerics | linear solve, root bracketing, table lookup, integration | pivoting, bisection, clamped interpolation, prefix sums |
| Layout | convex hull, point in polygon | orientation tests, exact integer predicates |
| Fabrication | stock cutting, fastener spacing | first-fit-decreasing, floating-point rounding |
| Parsing | imperial dimensions, load combination expressions | hand-written tokenising, longest-match |

Three of them are worth calling out because the naive answer looks right and is not:

- **9004 Merge Coincident Nodes.** Snapping coordinates to a tolerance-sized grid is the
  obvious approach and it is wrong, because merging is transitive.
- **9008 Axle Train Maximum Reaction.** The train position is continuous, so stepping
  along in small increments misses the peak. The reaction falls monotonically between
  breakpoints, which collapses the search to a handful of positions.
- **9016 Fastener Layout.** `Math.Ceiling(1.1 / 0.1)` is 12, not 11, and that adds a
  fastener that is not needed.

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
dotnet test --project verify/LeetCodeLab.Verify      # 1580 tests, all green
```

going green means the expectations you are judged against are correct. It caught three real
bugs while this was built: empty `ListNode`/`TreeNode` canonicalising to `null` instead of
`[]`, a `PriorityQueue` used with a constant priority, and a folder named `Math` shadowing
`System.Math`. It has since caught a hand-written expectation too — Next Greater Element II
was entered as though it were the linear version, when the whole point of it is the wrap.

**`verify/` contains full solutions to every problem. Stay out of it unless you mean to.**

## Why there is a harness at all

LeetCode is not uniformly "assert equal", which is why you cannot just write `Assert.Equal`:

| Mode | # | Meaning | Example |
| --- | --- | --- | --- |
| `Exact` | 161 | deep structural equality | most problems |
| `FloatTolerance` | 12 | numeric within 1e-5 | Pow(x, n), most of the engineering set |
| `MutatedArg` | 10 | the answer is the mutated argument, not the return | Move Zeroes, Game of Life |
| `Unordered` | 9 | flat sequence, order irrelevant | Two Sum, Permutations |
| `Design` | 9 | constructor + method-call sequence on a stateful object | LRU Cache, Trie |
| `UnorderedNested` | 6 | sequence of sequences, neither order matters | 3Sum, Free Edges of a Mesh |
| `AnyValid` | 5 | several answers accepted; a `Validate` method judges | Find Peak Element |
| `InPlacePrefix` | 3 | returns `k`; only the first `k` mutated elements count | Remove Duplicates |

Arguments bind by **your method signature**, not by a type hint in the data. The same JSON
`[1,2,3]` becomes an `int[]`, a `ListNode` or a `TreeNode` depending on what your method
asks for, so you write the natural C# signature and the harness adapts.

## Time and memory limits

Every case runs on a dedicated worker thread with a wall-clock budget (5 s by default,
`timeoutMs` per problem or per case) and an optional `maxAllocatedBytes` cap. Blowing either
fails the test with a specific message rather than hanging the run.

A timer alone would be theatre, though: an O(n²) Two Sum finishes instantly on
`[2,7,11,15]`. So thirteen problems also carry a **stress case** with a large generated input,
sized so the intended complexity passes comfortably and the naive approach cannot:

| Problem | Input | Traps |
| --- | --- | --- |
| 3, 42, 53, 55, 121, 128, 215, 217 | 200k elements | O(n²) scans |
| 239 Sliding Window Maximum | 200k elements, k = n | O(nk) rescanning of the window |
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

`url` may be left out or left empty, in which case no link line is rendered — that is how
the original problems in the 9000 range are written. Give those a `"topics"` entry of
`"Original"` so they stay filterable as a set.

One rule when choosing `folder`: it becomes a namespace segment, so **do not name it after a
BCL type**. A folder called `Math` makes `Math.Abs` resolve to the namespace and fail to
compile, which is why the folders here are `Numbers`, `Stacks` and `LinkedLists`.

## What this does not do

**These are the published example cases plus hand-written stress cases, not LeetCode's judge
suite.** The hidden tests are not available anywhere, so green here means your logic handles
the examples, the edge cases in the data, and — on the twelve problems that have one — a
large input. It does not mean you would get "Accepted": the other 152 problems have no
timing pressure, and nothing here checks for integer overflow on adversarial inputs.

The original problems in the 9000 range are a different case again. They have no judge
anywhere, so their expectations are hand-computed and then held to a reference solution by
`verify/` — which is the only thing standing behind them.

What it does catch is the errors you actually make while learning, in a debugger, offline.

## Requirements

.NET 10 SDK. `global.json` opts `dotnet test` into Microsoft.Testing.Platform, which is what
xUnit v3 runs on; without it the .NET 10 SDK tries the retired VSTest path and errors out.
