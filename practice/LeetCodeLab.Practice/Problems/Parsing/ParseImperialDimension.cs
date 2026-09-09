namespace LeetCodeLab.Practice.Problems.Parsing;

// ============================================================================
//  9017. Parse an Imperial Dimension                                  [Medium]
// ----------------------------------------------------------------------------
//  Read a dimension the way a drawing writes it and return it in inches. The
//  text may carry feet, marked with an apostrophe; inches, marked with a
//  double quote; or both, separated by a hyphen. The inches part may be a
//  whole number, a fraction like 1/2, or a whole number and a fraction like 6
//  1/2. Spaces may appear anywhere, including around the hyphen and at the
//  ends. Return -1 for anything you cannot read as a dimension.
//
//  Examples
//    text = "12'-6\""  ->  150
//    text = "6\""  ->  6
//    text = "12'"  ->  144
//
//  Constraints
//    0 <= text.Length <= 100
//    feet and inches are non-negative whole numbers; fraction denominators are non-zero
//    the empty string is not a dimension
//    answers are checked to 1e-5
//
//  Hints (read only as many as you need)
//    1. Do not try to write one regular expression for the whole thing. Strip
//       the spaces you do not need, then take the string apart at the two
//       markers.
//    2. Split on the apostrophe first: what comes before it is feet, what
//       comes after is the inches part with its hyphen and double quote to
//       remove. No apostrophe means the whole thing is inches.
//    3. The inches part has three shapes: whole, fraction, and
//       whole-plus-fraction. Splitting it on a space tells you which one you
//       have, and splitting a piece on the slash gives numerator and
//       denominator. Fail closed - anything that does not parse as a number
//       is -1, not an exception.
//
//  Aim for O(n) time, O(n) space
// ============================================================================
[Problem(9017)]
public sealed class ParseImperialDimension : ProblemTests<ParseImperialDimension>
{
    public double Solve(string text)
    {
        throw new NotImplementedException();
    }
}
