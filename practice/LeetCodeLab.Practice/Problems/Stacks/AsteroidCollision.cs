namespace LeetCodeLab.Practice.Problems.Stacks;

// ============================================================================
//  735. Asteroid Collision                                            [Medium]
//  https://leetcode.com/problems/asteroid-collision/
// ----------------------------------------------------------------------------
//  Each value is an asteroid: the magnitude is its size and the sign is its
//  direction, positive for right and negative for left. All move at the same
//  speed. When two meet, the smaller explodes; if they are the same size both
//  explode. Asteroids moving the same way, or apart, never meet. Return the
//  state once everything has settled.
//
//  Examples
//    asteroids = [5,10,-5]  ->  [5,10]
//    asteroids = [8,-8]  ->  []
//    asteroids = [10,2,-5]  ->  [10]
//
//  Constraints
//    2 <= asteroids.Length <= 10^4
//    values are non-zero
//    a collision happens only when a right-mover is immediately followed by a left-mover
//    equal sizes destroy each other
//
//  Hints (read only as many as you need)
//    1. A collision needs a positive asteroid on the left and a negative one
//       on the right. Two negatives, two positives, or a negative then a
//       positive all pass by untouched.
//    2. Keep the survivors on a stack. A new left-mover has to fight the
//       right-movers on top until one of them wins or it is destroyed.
//    3. Three outcomes per fight and they are easy to muddle: the stack top
//       is smaller so it pops and the fight continues; sizes are equal so
//       both die; the top is bigger so the newcomer dies. Only the case where
//       the newcomer survives every fight lets it get pushed.
//
//  Aim for O(n) time
// ============================================================================
[Problem(735)]
public sealed class AsteroidCollision : ProblemTests<AsteroidCollision>
{
    public int[] Solve(int[] asteroids)
    {
        throw new NotImplementedException();
    }
}
