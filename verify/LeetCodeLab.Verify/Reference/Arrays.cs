namespace LeetCodeLab.Verify.Reference;

// Reference implementations exist only to prove the case files in /data are correct.
// If this project is green, the expectations the practice stubs are judged against
// are consistent with a known-good solution.

[Problem(1)]
public sealed class TwoSum : ProblemTests<TwoSum>
{
    public int[] Solve(int[] nums, int target)
    {
        Dictionary<int, int> seen = [];
        for (int i = 0; i < nums.Length; i++)
        {
            if (seen.TryGetValue(target - nums[i], out int j)) return [j, i];
            seen[nums[i]] = i;
        }
        return [];
    }
}

[Problem(26)]
public sealed class RemoveDuplicatesFromSortedArray : ProblemTests<RemoveDuplicatesFromSortedArray>
{
    public int Solve(int[] nums)
    {
        if (nums.Length == 0) return 0;
        int k = 1;
        for (int i = 1; i < nums.Length; i++)
            if (nums[i] != nums[k - 1]) nums[k++] = nums[i];
        return k;
    }
}

[Problem(49)]
public sealed class GroupAnagrams : ProblemTests<GroupAnagrams>
{
    public IList<IList<string>> Solve(string[] strs)
    {
        Dictionary<string, IList<string>> groups = [];
        foreach (string s in strs)
        {
            char[] key = s.ToCharArray();
            Array.Sort(key);
            string k = new(key);
            if (!groups.TryGetValue(k, out IList<string>? bucket)) groups[k] = bucket = [];
            bucket.Add(s);
        }
        return [.. groups.Values];
    }
}

[Problem(53)]
public sealed class MaximumSubarray : ProblemTests<MaximumSubarray>
{
    public int Solve(int[] nums)
    {
        int best = nums[0], running = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            running = Math.Max(nums[i], running + nums[i]);
            best = Math.Max(best, running);
        }
        return best;
    }
}

[Problem(121)]
public sealed class BestTimeToBuyAndSellStock : ProblemTests<BestTimeToBuyAndSellStock>
{
    public int Solve(int[] prices)
    {
        int cheapest = int.MaxValue, best = 0;
        foreach (int price in prices)
        {
            cheapest = Math.Min(cheapest, price);
            best = Math.Max(best, price - cheapest);
        }
        return best;
    }
}

[Problem(128)]
public sealed class LongestConsecutiveSequence : ProblemTests<LongestConsecutiveSequence>
{
    public int Solve(int[] nums)
    {
        HashSet<int> set = [.. nums];
        int best = 0;
        foreach (int n in set)
        {
            if (set.Contains(n - 1)) continue;
            int length = 1;
            while (set.Contains(n + length)) length++;
            best = Math.Max(best, length);
        }
        return best;
    }
}

[Problem(217)]
public sealed class ContainsDuplicate : ProblemTests<ContainsDuplicate>
{
    public bool Solve(int[] nums) => new HashSet<int>(nums).Count != nums.Length;
}

[Problem(238)]
public sealed class ProductOfArrayExceptSelf : ProblemTests<ProductOfArrayExceptSelf>
{
    public int[] Solve(int[] nums)
    {
        int[] result = new int[nums.Length];
        int running = 1;
        for (int i = 0; i < nums.Length; i++) { result[i] = running; running *= nums[i]; }
        running = 1;
        for (int i = nums.Length - 1; i >= 0; i--) { result[i] *= running; running *= nums[i]; }
        return result;
    }
}

[Problem(242)]
public sealed class ValidAnagram : ProblemTests<ValidAnagram>
{
    public bool Solve(string s, string t)
    {
        if (s.Length != t.Length) return false;
        Dictionary<char, int> counts = [];
        foreach (char c in s) counts[c] = counts.GetValueOrDefault(c) + 1;
        foreach (char c in t)
        {
            if (!counts.TryGetValue(c, out int n) || n == 0) return false;
            counts[c] = n - 1;
        }
        return true;
    }
}

[Problem(283)]
public sealed class MoveZeroes : ProblemTests<MoveZeroes>
{
    public void Solve(int[] nums)
    {
        int write = 0;
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != 0) nums[write++] = nums[i];
        while (write < nums.Length) nums[write++] = 0;
    }
}

[Problem(347)]
public sealed class TopKFrequentElements : ProblemTests<TopKFrequentElements>
{
    public int[] Solve(int[] nums, int k)
    {
        Dictionary<int, int> counts = [];
        foreach (int n in nums) counts[n] = counts.GetValueOrDefault(n) + 1;
        return [.. counts.OrderByDescending(pair => pair.Value).Take(k).Select(pair => pair.Key)];
    }
}
