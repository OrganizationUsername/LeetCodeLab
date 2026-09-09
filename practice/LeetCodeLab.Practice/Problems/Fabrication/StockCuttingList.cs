namespace LeetCodeLab.Practice.Problems.Fabrication;

// ============================================================================
//  9015. Stock Cutting List                                           [Medium]
// ----------------------------------------------------------------------------
//  You need a list of pieces cut from stock lengths, and every cut separating
//  two pieces wastes kerf of material. A stock length holding c pieces
//  therefore uses the sum of those pieces plus kerf times (c - 1). Report how
//  many stock lengths the FIRST-FIT-DECREASING rule uses: sort the pieces
//  longest first, and put each into the first stock length it still fits in,
//  starting a new one only when it fits in none. Return -1 if any single
//  piece is longer than the stock.
//
//  Examples
//    pieces = [60,40,30,70], stockLength = 100, kerf = 0  ->  2
//    pieces = [50,50,50], stockLength = 100, kerf = 0  ->  2
//    pieces = [50,50], stockLength = 100, kerf = 1  ->  2
//
//  Constraints
//    1 <= pieces.Length <= 10^4
//    1 <= stockLength <= 10^6, 0 <= kerf < stockLength
//    first-fit-decreasing is a heuristic, not the optimum: it can use more stock than the best possible packing, and finding that optimum is NP-hard. The answer wanted here is what the stated rule produces.
//
//  Hints (read only as many as you need)
//    1. Do the accounting before the algorithm. Track the length already used
//       in each open stock length, and remember that adding a piece to a
//       stock length that is not empty costs kerf as well as the piece.
//    2. First-fit-decreasing is two steps: sort descending, then for each
//       piece scan the open stock lengths in the order they were opened and
//       take the first that fits.
//    3. The -1 check is easiest before you start - if the longest piece does
//       not fit an empty stock length, nothing will. Scanning all open bins
//       per piece is O(n^2) and fine at this size; a real cutting optimiser
//       would keep the remaining capacities in a tree.
//
//  Aim for O(n^2) time, O(n) space
// ============================================================================
[Problem(9015)]
public sealed class StockCuttingList : ProblemTests<StockCuttingList>
{
    public int Solve(int[] pieces, int stockLength, int kerf)
    {
        throw new NotImplementedException();
    }
}
