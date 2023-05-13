public class Solution {
    public int Tribonacci(int n) {
        if (n < 3)
            return n > 0 ? 1 : 0;
        int[] x = new int[3] {0,1,1};
        for(int i = 2; i < n; i++) {
            int t = x[0] + x[1] + x[2];
            x[0] = x[1];
            x[1] = x[2];
            x[2] = t;
        }
        return x[2];
    }
}