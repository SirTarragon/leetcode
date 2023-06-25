public class Solution {
    public int ConcatenatedBinary(int n) {
        long output = 0;
        int mod = 1000000007;
        int displacement = 0;
        for(int i = 1; i <= n; i++) {
            int temp = i >> displacement;
            while(temp != 0) {
                temp >>= 1;
                displacement++;
            }
            output = ((output << displacement) | i) % mod;
        }
        return Convert.ToInt32(output);
    }
}