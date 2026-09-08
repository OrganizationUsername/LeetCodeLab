namespace LeetCodeLab.Core;

/// <summary>
/// A fixed xorshift32 generator. Deliberately not System.Random: that algorithm changed
/// between .NET versions, and stress-case expectations are baked into the data files, so
/// the inputs must be reproducible forever.
/// </summary>
public sealed class DeterministicRandom(uint seed)
{
    private uint _state = seed == 0 ? 0x9E3779B9u : seed;

    public uint NextUInt()
    {
        uint x = _state;
        x ^= x << 13;
        x ^= x >> 17;
        x ^= x << 5;
        return _state = x;
    }

    public int NextInt(int minInclusive, int maxInclusive)
    {
        ulong range = (ulong)((long)maxInclusive - minInclusive + 1);
        return (int)(minInclusive + (long)(NextUInt() % range));
    }
}

/// <summary>
/// Builds the large inputs that make timing meaningful. Example cases are far too small
/// for a quadratic solution to look any different from a linear one.
/// </summary>
public static class Generated
{
    public static int[] Ints(uint seed, int count, int min, int max)
    {
        DeterministicRandom random = new(seed);
        int[] values = new int[count];
        for (int i = 0; i < count; i++) values[i] = random.NextInt(min, max);
        return values;
    }

    public static int[] SortedInts(uint seed, int count, int min, int max)
    {
        int[] values = Ints(seed, count, min, max);
        Array.Sort(values);
        return values;
    }

    /// <summary>A shuffle of 0..count-1, so every value is distinct and the run is complete.</summary>
    public static int[] Permutation(uint seed, int count)
    {
        DeterministicRandom random = new(seed);
        int[] values = new int[count];
        for (int i = 0; i < count; i++) values[i] = i;
        for (int i = count - 1; i > 0; i--)
        {
            int j = random.NextInt(0, i);
            (values[i], values[j]) = (values[j], values[i]);
        }
        return values;
    }

    public static string RepeatedChar(int count, char c) => new(c, count);

    public static string RandomString(uint seed, int count, string alphabet)
    {
        DeterministicRandom random = new(seed);
        char[] buffer = new char[count];
        for (int i = 0; i < count; i++) buffer[i] = alphabet[random.NextInt(0, alphabet.Length - 1)];
        return new string(buffer);
    }
}
