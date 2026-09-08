namespace LeetCodeLab.Verify.Reference;

[Problem(20)]
public sealed class ValidParentheses : ProblemTests<ValidParentheses>
{
    public bool Solve(string s)
    {
        Dictionary<char, char> pairs = new() { [')'] = '(', [']'] = '[', ['}'] = '{' };
        Stack<char> open = new();
        foreach (char c in s)
        {
            if (pairs.TryGetValue(c, out char match))
            {
                if (open.Count == 0 || open.Pop() != match) return false;
            }
            else open.Push(c);
        }
        return open.Count == 0;
    }
}

[Problem(150)]
public sealed class EvaluateReversePolishNotation : ProblemTests<EvaluateReversePolishNotation>
{
    public int Solve(string[] tokens)
    {
        Stack<int> stack = new();
        foreach (string token in tokens)
        {
            if (token is "+" or "-" or "*" or "/")
            {
                int b = stack.Pop(), a = stack.Pop();
                stack.Push(token switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    _ => a / b,
                });
            }
            else stack.Push(int.Parse(token));
        }
        return stack.Pop();
    }
}

[Problem(739)]
public sealed class DailyTemperatures : ProblemTests<DailyTemperatures>
{
    public int[] Solve(int[] temperatures)
    {
        int[] result = new int[temperatures.Length];
        Stack<int> pending = new();
        for (int i = 0; i < temperatures.Length; i++)
        {
            while (pending.Count > 0 && temperatures[i] > temperatures[pending.Peek()])
            {
                int day = pending.Pop();
                result[day] = i - day;
            }
            pending.Push(i);
        }
        return result;
    }
}

[Problem(33)]
public sealed class SearchInRotatedSortedArray : ProblemTests<SearchInRotatedSortedArray>
{
    public int Solve(int[] nums, int target)
    {
        int lo = 0, hi = nums.Length - 1;
        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (nums[mid] == target) return mid;

            if (nums[lo] <= nums[mid])
            {
                if (nums[lo] <= target && target < nums[mid]) hi = mid - 1; else lo = mid + 1;
            }
            else
            {
                if (nums[mid] < target && target <= nums[hi]) lo = mid + 1; else hi = mid - 1;
            }
        }
        return -1;
    }
}

[Problem(153)]
public sealed class FindMinimumInRotatedSortedArray : ProblemTests<FindMinimumInRotatedSortedArray>
{
    public int Solve(int[] nums)
    {
        int lo = 0, hi = nums.Length - 1;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (nums[mid] > nums[hi]) lo = mid + 1; else hi = mid;
        }
        return nums[lo];
    }
}

[Problem(704)]
public sealed class BinarySearch : ProblemTests<BinarySearch>
{
    public int Solve(int[] nums, int target)
    {
        int lo = 0, hi = nums.Length - 1;
        while (lo <= hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (nums[mid] == target) return mid;
            if (nums[mid] < target) lo = mid + 1; else hi = mid - 1;
        }
        return -1;
    }
}

[Problem(875)]
public sealed class KokoEatingBananas : ProblemTests<KokoEatingBananas>
{
    public int Solve(int[] piles, int h)
    {
        int lo = 1, hi = piles.Max();
        while (lo < hi)
        {
            int speed = lo + (hi - lo) / 2;
            long hours = piles.Sum(pile => (long)((pile + speed - 1) / speed));
            if (hours <= h) hi = speed; else lo = speed + 1;
        }
        return lo;
    }
}
