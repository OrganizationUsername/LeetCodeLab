using System.Globalization;

namespace LeetCodeLab.Verify.Reference;

// Reference implementations for the original (non-LeetCode) engineering problems,
// ids 9001 and up. They exist only to prove the hand-written case files.

[Problem(9001)]
public sealed class PolygonSectionProperties : ProblemTests<PolygonSectionProperties>
{
    public double[] Solve(double[][] vertices)
    {
        int n = vertices.Length;
        double twiceArea = 0, cx = 0, cy = 0;

        for (int i = 0; i < n; i++)
        {
            double[] p = vertices[i], q = vertices[(i + 1) % n];
            double cross = p[0] * q[1] - q[0] * p[1];
            twiceArea += cross;
            cx += (p[0] + q[0]) * cross;
            cy += (p[1] + q[1]) * cross;
        }

        // Divide by the SIGNED area; taking the absolute value earlier mirrors a clockwise polygon.
        double signedArea = twiceArea / 2;
        return [Math.Abs(signedArea), cx / (6 * signedArea), cy / (6 * signedArea)];
    }
}

[Problem(9002)]
public sealed class BuiltUpSectionInertia : ProblemTests<BuiltUpSectionInertia>
{
    public double[] Solve(double[][] rectangles)
    {
        double area = 0, firstMoment = 0;
        foreach (double[] r in rectangles)
        {
            double a = r[2] * r[3];
            area += a;
            firstMoment += a * (r[1] + r[3] / 2);
        }

        double ybar = firstMoment / area;

        double ixx = 0;
        foreach (double[] r in rectangles)
        {
            double a = r[2] * r[3];
            double d = r[1] + r[3] / 2 - ybar;
            ixx += r[2] * r[3] * r[3] * r[3] / 12 + a * d * d;
        }

        return [area, ybar, ixx];
    }
}

[Problem(9003)]
public sealed class FreeEdgesOfAMesh : ProblemTests<FreeEdgesOfAMesh>
{
    public int[][] Solve(int[][] triangles)
    {
        Dictionary<(int, int), int> counts = [];

        foreach (int[] t in triangles)
        {
            Add(t[0], t[1]);
            Add(t[1], t[2]);
            Add(t[0], t[2]);
        }

        void Add(int a, int b)
        {
            (int, int) key = a < b ? (a, b) : (b, a);
            counts[key] = counts.GetValueOrDefault(key) + 1;
        }

        return [.. counts.Where(entry => entry.Value == 1)
                         .Select(entry => new[] { entry.Key.Item1, entry.Key.Item2 })];
    }
}

[Problem(9004)]
public sealed class MergeCoincidentNodes : ProblemTests<MergeCoincidentNodes>
{
    public int Solve(double[][] points, double tolerance)
    {
        int n = points.Length;
        int[] parent = new int[n];
        for (int i = 0; i < n; i++) parent[i] = i;

        int Find(int x)
        {
            while (parent[x] != x) { parent[x] = parent[parent[x]]; x = parent[x]; }
            return x;
        }

        double limit = tolerance * tolerance;
        for (int i = 0; i < n; i++)
            for (int j = i + 1; j < n; j++)
            {
                double dx = points[i][0] - points[j][0];
                double dy = points[i][1] - points[j][1];
                if (dx * dx + dy * dy <= limit) parent[Find(i)] = Find(j);
            }

        HashSet<int> roots = [];
        for (int i = 0; i < n; i++) roots.Add(Find(i));
        return roots.Count;
    }
}

[Problem(9005)]
public sealed class MinimumBandwidthNumbering : ProblemTests<MinimumBandwidthNumbering>
{
    public int Solve(int n, int[][] members)
    {
        if (members.Length == 0) return 0;

        int[] label = new int[n];
        bool[] used = new bool[n];
        int best = int.MaxValue;

        void Search(int position)
        {
            if (position == n)
            {
                int span = 0;
                foreach (int[] m in members)
                    span = Math.Max(span, Math.Abs(label[m[0]] - label[m[1]]));
                best = Math.Min(best, span);
                return;
            }

            for (int node = 0; node < n; node++)
            {
                if (used[node]) continue;
                used[node] = true;
                label[node] = position;
                Search(position + 1);
                used[node] = false;
            }
        }

        Search(0);
        return best;
    }
}

[Problem(9006)]
public sealed class LoadPathToGround : ProblemTests<LoadPathToGround>
{
    public int[] Solve(int n, int[][] members, int[] supports)
    {
        List<int>[] adjacency = new List<int>[n];
        for (int i = 0; i < n; i++) adjacency[i] = [];
        foreach (int[] m in members)
        {
            adjacency[m[0]].Add(m[1]);
            adjacency[m[1]].Add(m[0]);
        }

        bool[] grounded = new bool[n];
        Queue<int> queue = new();
        foreach (int support in supports)
            if (!grounded[support]) { grounded[support] = true; queue.Enqueue(support); }

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            foreach (int next in adjacency[node])
                if (!grounded[next]) { grounded[next] = true; queue.Enqueue(next); }
        }

        List<int> floating = [];
        for (int i = 0; i < n; i++) if (!grounded[i]) floating.Add(i);
        return [.. floating];
    }
}

[Problem(9007)]
public sealed class LoadCombinationEnvelope : ProblemTests<LoadCombinationEnvelope>
{
    public double[][] Solve(double[][] caseResults, double[][] factors)
    {
        int cases = caseResults.Length, stations = caseResults[0].Length;
        double[] max = new double[stations], min = new double[stations];

        for (int combination = 0; combination < factors.Length; combination++)
            for (int station = 0; station < stations; station++)
            {
                double total = 0;
                for (int c = 0; c < cases; c++)
                    total += factors[combination][c] * caseResults[c][station];

                if (combination == 0) max[station] = min[station] = total;
                else
                {
                    max[station] = Math.Max(max[station], total);
                    min[station] = Math.Min(min[station], total);
                }
            }

        return [max, min];
    }
}

[Problem(9008)]
public sealed class AxleTrainMaximumReaction : ProblemTests<AxleTrainMaximumReaction>
{
    public double Solve(double span, double[] loads, double[] offsets)
    {
        // The reaction falls as the train advances, so every local peak sits where the set
        // of on-span axles changes: some axle exactly at one support or the other.
        List<double> positions = [];
        foreach (double offset in offsets)
        {
            positions.Add(-offset);
            positions.Add(span - offset);
        }

        double best = 0;
        foreach (double lead in positions)
        {
            double reaction = 0;
            for (int i = 0; i < loads.Length; i++)
            {
                double x = lead + offsets[i];
                if (x < -1e-9 || x > span + 1e-9) continue;
                reaction += loads[i] * (span - Math.Clamp(x, 0, span)) / span;
            }
            best = Math.Max(best, reaction);
        }
        return best;
    }
}

[Problem(9009)]
public sealed class SolveALinearSystem : ProblemTests<SolveALinearSystem>
{
    public double[] Solve(double[][] a, double[] b)
    {
        int n = b.Length;

        for (int k = 0; k < n; k++)
        {
            int pivot = k;
            for (int r = k + 1; r < n; r++)
                if (Math.Abs(a[r][k]) > Math.Abs(a[pivot][k])) pivot = r;

            (a[k], a[pivot]) = (a[pivot], a[k]);
            (b[k], b[pivot]) = (b[pivot], b[k]);

            for (int r = k + 1; r < n; r++)
            {
                double factor = a[r][k] / a[k][k];
                if (factor == 0) continue;
                for (int c = k; c < n; c++) a[r][c] -= factor * a[k][c];
                b[r] -= factor * b[k];
            }
        }

        double[] x = new double[n];
        for (int i = n - 1; i >= 0; i--)
        {
            double sum = b[i];
            for (int j = i + 1; j < n; j++) sum -= a[i][j] * x[j];
            x[i] = sum / a[i][i];
        }
        return x;
    }
}

[Problem(9010)]
public sealed class BracketedPolynomialRoot : ProblemTests<BracketedPolynomialRoot>
{
    public double Solve(double[] coefficients, double lo, double hi)
    {
        double At(double x)
        {
            double result = 0;
            for (int i = coefficients.Length - 1; i >= 0; i--) result = result * x + coefficients[i];
            return result;
        }

        double atLo = At(lo);
        if (atLo == 0) return lo;
        if (At(hi) == 0) return hi;

        for (int iteration = 0; iteration < 200; iteration++)
        {
            double mid = (lo + hi) / 2;
            double atMid = At(mid);
            if (atMid == 0) return mid;

            if (atLo * atMid < 0) hi = mid;
            else { lo = mid; atLo = atMid; }
        }
        return (lo + hi) / 2;
    }
}

[Problem(9011)]
public sealed class DesignTableLookup : ProblemTests<DesignTableLookup>
{
    public double Solve(double[] rowKeys, double[] colKeys, double[][] table, double row, double col)
    {
        (int Index, double Fraction) Bracket(double[] keys, double value)
        {
            if (keys.Length == 1) return (0, 0);

            int lo = 0, hi = keys.Length - 2;
            while (lo < hi)
            {
                int mid = (lo + hi + 1) / 2;
                if (keys[mid] <= value) lo = mid; else hi = mid - 1;
            }

            double fraction = (value - keys[lo]) / (keys[lo + 1] - keys[lo]);
            return (lo, Math.Clamp(fraction, 0, 1));
        }

        (int rowIndex, double rowFraction) = Bracket(rowKeys, row);
        (int colIndex, double colFraction) = Bracket(colKeys, col);

        int rowNext = rowKeys.Length == 1 ? rowIndex : rowIndex + 1;
        int colNext = colKeys.Length == 1 ? colIndex : colIndex + 1;

        double near = table[rowIndex][colIndex]
            + colFraction * (table[rowIndex][colNext] - table[rowIndex][colIndex]);
        double far = table[rowNext][colIndex]
            + colFraction * (table[rowNext][colNext] - table[rowNext][colIndex]);

        return near + rowFraction * (far - near);
    }
}

[Problem(9012)]
public sealed class MomentFromShearDiagram : ProblemTests<MomentFromShearDiagram>
{
    public double[] Solve(double[] x, double[] v)
    {
        double[] moment = new double[x.Length];
        double running = 0;

        for (int i = 1; i < x.Length; i++)
        {
            running += (v[i] + v[i - 1]) / 2 * (x[i] - x[i - 1]);
            moment[i] = running;
        }
        return moment;
    }
}

[Problem(9013)]
public sealed class ColumnFootprintHull : ProblemTests<ColumnFootprintHull>
{
    public int[][] Solve(int[][] points)
    {
        int[][] sorted = [.. points.OrderBy(p => p[0]).ThenBy(p => p[1])];
        int n = sorted.Length;
        if (n <= 2) return sorted;

        static long Cross(int[] o, int[] a, int[] b)
            => (long)(a[0] - o[0]) * (b[1] - o[1]) - (long)(a[1] - o[1]) * (b[0] - o[0]);

        List<int[]> lower = [];
        foreach (int[] p in sorted)
        {
            while (lower.Count >= 2 && Cross(lower[^2], lower[^1], p) <= 0)
                lower.RemoveAt(lower.Count - 1);
            lower.Add(p);
        }

        List<int[]> upper = [];
        for (int i = n - 1; i >= 0; i--)
        {
            int[] p = sorted[i];
            while (upper.Count >= 2 && Cross(upper[^2], upper[^1], p) <= 0)
                upper.RemoveAt(upper.Count - 1);
            upper.Add(p);
        }

        lower.RemoveAt(lower.Count - 1);
        upper.RemoveAt(upper.Count - 1);
        lower.AddRange(upper);
        return [.. lower];
    }
}

[Problem(9014)]
public sealed class PointInSlabOutline : ProblemTests<PointInSlabOutline>
{
    public bool Solve(int[][] polygon, int[] point)
    {
        int n = polygon.Length;
        int px = point[0], py = point[1];

        // On the boundary counts as on the slab, so settle that first and exactly.
        for (int i = 0; i < n; i++)
        {
            int[] a = polygon[i], b = polygon[(i + 1) % n];
            long cross = (long)(b[0] - a[0]) * (py - a[1]) - (long)(b[1] - a[1]) * (px - a[0]);
            if (cross == 0
                && Math.Min(a[0], b[0]) <= px && px <= Math.Max(a[0], b[0])
                && Math.Min(a[1], b[1]) <= py && py <= Math.Max(a[1], b[1]))
                return true;
        }

        bool inside = false;
        for (int i = 0; i < n; i++)
        {
            int[] a = polygon[i], b = polygon[(i + 1) % n];
            if ((a[1] > py) == (b[1] > py)) continue;

            double crossingX = (double)(b[0] - a[0]) * (py - a[1]) / (b[1] - a[1]) + a[0];
            if (px < crossingX) inside = !inside;
        }
        return inside;
    }
}

[Problem(9015)]
public sealed class StockCuttingList : ProblemTests<StockCuttingList>
{
    public int Solve(int[] pieces, int stockLength, int kerf)
    {
        foreach (int piece in pieces) if (piece > stockLength) return -1;

        int[] descending = [.. pieces.OrderByDescending(p => p)];
        List<int> used = [];

        foreach (int piece in descending)
        {
            bool placed = false;
            for (int i = 0; i < used.Count; i++)
            {
                if (used[i] + kerf + piece > stockLength) continue;
                used[i] += kerf + piece;
                placed = true;
                break;
            }
            if (!placed) used.Add(piece);
        }
        return used.Count;
    }
}

[Problem(9016)]
public sealed class FastenerLayout : ProblemTests<FastenerLayout>
{
    public int Solve(double runLength, double maxSpacing, double endDistance)
    {
        double span = runLength - 2 * endDistance;
        if (span <= 0) return 1;

        // Ceiling on a quotient that should be whole lands one too high in binary, so
        // shave a relative epsilon off first: 1.1 / 0.1 is 11.000000000000002.
        double exact = span / maxSpacing;
        int gaps = (int)Math.Ceiling(exact - 1e-9 * Math.Max(1, Math.Abs(exact)));
        return Math.Max(gaps, 1) + 1;
    }
}

[Problem(9017)]
public sealed class ParseImperialDimension : ProblemTests<ParseImperialDimension>
{
    public double Solve(string text)
    {
        if (string.IsNullOrWhiteSpace(text)) return -1;

        string cleaned = text.Trim();
        double feet = 0;
        string inchPart = cleaned;

        int apostrophe = cleaned.IndexOf('\'');
        if (apostrophe >= 0)
        {
            if (!TryNumber(cleaned[..apostrophe].Trim(), out feet)) return -1;
            inchPart = cleaned[(apostrophe + 1)..].Trim();
            if (inchPart.StartsWith('-')) inchPart = inchPart[1..].Trim();
        }

        if (inchPart.EndsWith('"')) inchPart = inchPart[..^1].Trim();
        else if (apostrophe < 0) return -1;

        if (inchPart.Length == 0) return feet * 12;

        string[] parts = inchPart.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length is 0 or > 2) return -1;

        double inches = 0;
        foreach (string part in parts)
        {
            if (part.Contains('/'))
            {
                string[] fraction = part.Split('/');
                if (fraction.Length != 2
                    || !TryNumber(fraction[0], out double numerator)
                    || !TryNumber(fraction[1], out double denominator)
                    || denominator == 0) return -1;
                inches += numerator / denominator;
            }
            else
            {
                if (!TryNumber(part, out double whole)) return -1;
                inches += whole;
            }
        }

        return feet * 12 + inches;
    }

    private static bool TryNumber(string text, out double value)
        => double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value);
}

[Problem(9018)]
public sealed class EvaluateLoadCombination : ProblemTests<EvaluateLoadCombination>
{
    public double Solve(string expression, string[] names, double[] values)
    {
        string compact = expression.Replace(" ", "");
        double total = 0;
        int i = 0;

        while (i < compact.Length)
        {
            int sign = 1;
            if (compact[i] == '+') i++;
            else if (compact[i] == '-') { sign = -1; i++; }

            int numberStart = i;
            while (i < compact.Length && (char.IsDigit(compact[i]) || compact[i] == '.')) i++;
            string coefficientText = compact[numberStart..i];
            double coefficient = coefficientText.Length == 0
                ? 1
                : double.Parse(coefficientText, CultureInfo.InvariantCulture);

            // Taking the whole run of letters as the name sidesteps L versus Lr entirely.
            int nameStart = i;
            while (i < compact.Length && char.IsLetter(compact[i])) i++;
            string name = compact[nameStart..i];

            int index = Array.IndexOf(names, name);
            if (index < 0) return double.NaN;

            total += sign * coefficient * values[index];
        }
        return total;
    }
}
