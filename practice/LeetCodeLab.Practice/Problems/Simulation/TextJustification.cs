namespace LeetCodeLab.Practice.Problems.Simulation;

// ============================================================================
//  68. Text Justification                                               [Hard]
//  https://leetcode.com/problems/text-justification/
// ----------------------------------------------------------------------------
//  Lay the words out into lines of exactly maxWidth characters, greedily
//  packing as many words per line as fit with at least one space between
//  neighbours. Pad each line by distributing the leftover spaces between the
//  words as evenly as possible, giving the extra spaces to the LEFTMOST gaps
//  first. A line holding one word, and the last line, are instead
//  left-justified with all the padding at the end.
//
//  Examples
//    words = ["This","is","an","example","of","text","ju..., maxWidth = 16  ->  ["Thisisan","exampleoftext","justification."]
//    words = ["What","must","be","acknowledgment","shall..., maxWidth = 16  ->  ["Whatmustbe","acknowledgment","shallbe"]
//    words = ["Science","is","what","we","understand","w..., maxWidth = 20  ->  ["Scienceiswhatwe","understandwell","enough...
//
//  Constraints
//    1 <= words.Length <= 300
//    1 <= words[i].Length <= 20 <= maxWidth <= 100
//    every word fits on a line by itself
//    words contain no spaces
//
//  Hints (read only as many as you need)
//    1. Two separable jobs: decide which words go on each line, then render
//       one line. Do not try to do both in one loop.
//    2. For the packing, a line holding words of total letter count L with g
//       gaps needs L + g characters at minimum. Add the next word while that
//       still fits in maxWidth.
//    3. For the rendering with g gaps and s spaces to place, every gap gets s
//       / g and the first s % g gaps get one more. Handle the two
//       left-justified exceptions before you reach that code, or you will
//       divide by zero on a single-word line.
//
//  Aim for O(total input length) time
// ============================================================================
[Problem(68)]
public sealed class TextJustification : ProblemTests<TextJustification>
{
    public IList<string> Solve(string[] words, int maxWidth)
    {
        throw new NotImplementedException();
    }
}
