public class Solution {
    public int KthFactor(int n, int k) {
        int factor = 1;
        while(k > 1 && factor++ <= n)
            if(n % factor == 0)
                k--;
        return k == 1 ? factor : -1;
    }
}