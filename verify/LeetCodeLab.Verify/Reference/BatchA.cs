namespace LeetCodeLab.Verify.Reference;

[Problem(27)]
public sealed class RemoveElement : ProblemTests<RemoveElement>
{
    public int Solve(int[] nums, int val)
    {
        int k = 0;
        foreach (int value in nums)
            if (value != val) nums[k++] = value;
        return k;
    }
}

[Problem(88)]
public sealed class MergeSortedArray : ProblemTests<MergeSortedArray>
{
    public void Solve(int[] nums1, int m, int[] nums2, int n)
    {
        int write = m + n - 1, a = m - 1, b = n - 1;
        while (b >= 0)
            nums1[write--] = a >= 0 && nums1[a] > nums2[b] ? nums1[a--] : nums2[b--];
    }
}

[Problem(169)]
public sealed class MajorityElement : ProblemTests<MajorityElement>
{
    public int Solve(int[] nums)
    {
        int candidate = nums[0], count = 0;
        foreach (int value in nums)
        {
            if (count == 0) candidate = value;
            count += value == candidate ? 1 : -1;
        }
        return candidate;
    }
}

[Problem(136)]
public sealed class SingleNumber : ProblemTests<SingleNumber>
{
    public int Solve(int[] nums)
    {
        int result = 0;
        foreach (int value in nums) result ^= value;
        return result;
    }
}

[Problem(268)]
public sealed class MissingNumber : ProblemTests<MissingNumber>
{
    public int Solve(int[] nums)
    {
        int n = nums.Length;
        int expected = n * (n + 1) / 2;
        return expected - nums.Sum();
    }
}

[Problem(66)]
public sealed class PlusOne : ProblemTests<PlusOne>
{
    public int[] Solve(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9) { digits[i]++; return digits; }
            digits[i] = 0;
        }
        int[] carried = new int[digits.Length + 1];
        carried[0] = 1;
        return carried;
    }
}

[Problem(118)]
public sealed class PascalsTriangle : ProblemTests<PascalsTriangle>
{
    public IList<IList<int>> Solve(int numRows)
    {
        List<IList<int>> rows = [];
        for (int r = 0; r < numRows; r++)
        {
            int[] row = new int[r + 1];
            row[0] = row[r] = 1;
            for (int c = 1; c < r; c++) row[c] = rows[r - 1][c - 1] + rows[r - 1][c];
            rows.Add(row);
        }
        return rows;
    }
}

[Problem(448)]
public sealed class FindDisappearedNumbers : ProblemTests<FindDisappearedNumbers>
{
    public IList<int> Solve(int[] nums)
    {
        foreach (int value in nums)
        {
            int index = Math.Abs(value) - 1;
            if (nums[index] > 0) nums[index] = -nums[index];
        }

        List<int> missing = [];
        for (int i = 0; i < nums.Length; i++)
            if (nums[i] > 0) missing.Add(i + 1);
        return missing;
    }
}

[Problem(189)]
public sealed class RotateArray : ProblemTests<RotateArray>
{
    public void Solve(int[] nums, int k)
    {
        k %= nums.Length;
        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    private static void Reverse(int[] nums, int lo, int hi)
    {
        while (lo < hi) { (nums[lo], nums[hi]) = (nums[hi], nums[lo]); lo++; hi--; }
    }
}

[Problem(977)]
public sealed class SquaresOfASortedArray : ProblemTests<SquaresOfASortedArray>
{
    public int[] Solve(int[] nums)
    {
        int[] result = new int[nums.Length];
        int lo = 0, hi = nums.Length - 1;
        for (int write = nums.Length - 1; write >= 0; write--)
        {
            int left = nums[lo] * nums[lo], right = nums[hi] * nums[hi];
            if (left > right) { result[write] = left; lo++; }
            else { result[write] = right; hi--; }
        }
        return result;
    }
}

[Problem(344)]
public sealed class ReverseString : ProblemTests<ReverseString>
{
    public void Solve(char[] s)
    {
        int lo = 0, hi = s.Length - 1;
        while (lo < hi) { (s[lo], s[hi]) = (s[hi], s[lo]); lo++; hi--; }
    }
}

[Problem(75)]
public sealed class SortColors : ProblemTests<SortColors>
{
    public void Solve(int[] nums)
    {
        int low = 0, high = nums.Length - 1, i = 0;
        while (i <= high)
        {
            if (nums[i] == 0) { (nums[i], nums[low]) = (nums[low], nums[i]); low++; i++; }
            else if (nums[i] == 2) { (nums[i], nums[high]) = (nums[high], nums[i]); high--; }
            else i++;
        }
    }
}

[Problem(14)]
public sealed class LongestCommonPrefix : ProblemTests<LongestCommonPrefix>
{
    public string Solve(string[] strs)
    {
        string prefix = strs[0];
        foreach (string candidate in strs)
            while (!candidate.StartsWith(prefix, StringComparison.Ordinal))
                prefix = prefix[..^1];
        return prefix;
    }
}

[Problem(28)]
public sealed class FirstOccurrenceInString : ProblemTests<FirstOccurrenceInString>
{
    public int Solve(string haystack, string needle) =>
        haystack.IndexOf(needle, StringComparison.Ordinal);
}

[Problem(9)]
public sealed class PalindromeNumber : ProblemTests<PalindromeNumber>
{
    public bool Solve(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;

        int reversedHalf = 0;
        while (x > reversedHalf)
        {
            reversedHalf = reversedHalf * 10 + x % 10;
            x /= 10;
        }
        return x == reversedHalf || x == reversedHalf / 10;
    }
}

[Problem(13)]
public sealed class RomanToInteger : ProblemTests<RomanToInteger>
{
    public int Solve(string s)
    {
        static int Value(char c) => c switch
        {
            'I' => 1, 'V' => 5, 'X' => 10, 'L' => 50,
            'C' => 100, 'D' => 500, 'M' => 1000, _ => 0,
        };

        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int current = Value(s[i]);
            total += i + 1 < s.Length && current < Value(s[i + 1]) ? -current : current;
        }
        return total;
    }
}

[Problem(202)]
public sealed class HappyNumber : ProblemTests<HappyNumber>
{
    public bool Solve(int n)
    {
        static int Step(int value)
        {
            int sum = 0;
            while (value > 0) { int d = value % 10; sum += d * d; value /= 10; }
            return sum;
        }

        int slow = n, fast = Step(n);
        while (fast != 1 && slow != fast)
        {
            slow = Step(slow);
            fast = Step(Step(fast));
        }
        return fast == 1;
    }
}

[Problem(7)]
public sealed class ReverseInteger : ProblemTests<ReverseInteger>
{
    public int Solve(int x)
    {
        int result = 0;
        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;
            if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > 7)) return 0;
            if (result < int.MinValue / 10 || (result == int.MinValue / 10 && digit < -8)) return 0;
            result = result * 10 + digit;
        }
        return result;
    }
}

[Problem(191)]
public sealed class NumberOfOneBits : ProblemTests<NumberOfOneBits>
{
    public int Solve(int n)
    {
        int count = 0;
        uint value = (uint)n;
        while (value != 0) { value &= value - 1; count++; }
        return count;
    }
}

[Problem(338)]
public sealed class CountingBits : ProblemTests<CountingBits>
{
    public int[] Solve(int n)
    {
        int[] result = new int[n + 1];
        for (int i = 1; i <= n; i++) result[i] = result[i >> 1] + (i & 1);
        return result;
    }
}
