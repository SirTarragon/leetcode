
public class Solution
{
    private int M, N;
    private Random rand;
    private HashSet<int> matrix;

    public Solution(int m, int n)
    {
        N = n; M = m;
        rand = new Random();
        matrix = new();
    }

    public int[] Flip()
    {
        while (true)
        {
            int[] res = { rand.Next(0, M), rand.Next(0, N) };
            int hashValue = res[0] * (M * N) + res[1];
            if (!matrix.Contains(hashValue)) {
                matrix.Add(hashValue);
                return res;
            }
        }
    }

    public void Reset()
    {
        matrix.Clear();
    }
}