namespace LeetCodeLab.Verify.Reference;

[Problem(11)]
public sealed class ContainerWithMostWater : ProblemTests<ContainerWithMostWater>
{
    public int Solve(int[] height)
    {
        int lo = 0, hi = height.Length - 1, best = 0;
        while (lo < hi)
        {
            best = Math.Max(best, (hi - lo) * Math.Min(height[lo], height[hi]));
            if (height[lo] < height[hi]) lo++; else hi--;
        }
        return best;
    }
}

[Problem(15)]
public sealed class ThreeSum : ProblemTests<ThreeSum>
{
    public IList<IList<int>> Solve(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> result = [];
        for (int i = 0; i + 2 < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            int lo = i + 1, hi = nums.Length - 1;
            while (lo < hi)
            {
                int sum = nums[i] + nums[lo] + nums[hi];
                if (sum < 0) lo++;
                else if (sum > 0) hi--;
                else
                {
                    result.Add([nums[i], nums[lo], nums[hi]]);
                    while (lo < hi && nums[lo] == nums[lo + 1]) lo++;
                    while (lo < hi && nums[hi] == nums[hi - 1]) hi--;
                    lo++; hi--;
                }
            }
        }
        return result;
    }
}

[Problem(42)]
public sealed class TrappingRainWater : ProblemTests<TrappingRainWater>
{
    public int Solve(int[] height)
    {
        if (height.Length == 0) return 0;
        int lo = 0, hi = height.Length - 1;
        int leftMax = height[0], rightMax = height[^1], total = 0;
        while (lo < hi)
        {
            if (leftMax < rightMax)
            {
                lo++;
                leftMax = Math.Max(leftMax, height[lo]);
                total += leftMax - height[lo];
            }
            else
            {
                hi--;
                rightMax = Math.Max(rightMax, height[hi]);
                total += rightMax - height[hi];
            }
        }
        return total;
    }
}

[Problem(125)]
public sealed class ValidPalindrome : ProblemTests<ValidPalindrome>
{
    public bool Solve(string s)
    {
        int lo = 0, hi = s.Length - 1;
        while (lo < hi)
        {
            while (lo < hi && !char.IsLetterOrDigit(s[lo])) lo++;
            while (lo < hi && !char.IsLetterOrDigit(s[hi])) hi--;
            if (char.ToLowerInvariant(s[lo]) != char.ToLowerInvariant(s[hi])) return false;
            lo++; hi--;
        }
        return true;
    }
}

[Problem(167)]
public sealed class TwoSumSortedInput : ProblemTests<TwoSumSortedInput>
{
    public int[] Solve(int[] numbers, int target)
    {
        int lo = 0, hi = numbers.Length - 1;
        while (lo < hi)
        {
            int sum = numbers[lo] + numbers[hi];
            if (sum == target) return [lo + 1, hi + 1];
            if (sum < target) lo++; else hi--;
        }
        return [];
    }
}

[Problem(3)]
public sealed class LongestSubstringWithoutRepeatingCharacters
    : ProblemTests<LongestSubstringWithoutRepeatingCharacters>
{
    public int Solve(string s)
    {
        Dictionary<char, int> lastSeen = [];
        int start = 0, best = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (lastSeen.TryGetValue(s[i], out int previous) && previous >= start)
                start = previous + 1;
            lastSeen[s[i]] = i;
            best = Math.Max(best, i - start + 1);
        }
        return best;
    }
}

[Problem(424)]
public sealed class LongestRepeatingCharacterReplacement
    : ProblemTests<LongestRepeatingCharacterReplacement>
{
    public int Solve(string s, int k)
    {
        int[] counts = new int[26];
        int start = 0, mostCommon = 0, best = 0;
        for (int i = 0; i < s.Length; i++)
        {
            mostCommon = Math.Max(mostCommon, ++counts[s[i] - 'A']);
            while (i - start + 1 - mostCommon > k) counts[s[start++] - 'A']--;
            best = Math.Max(best, i - start + 1);
        }
        return best;
    }
}
