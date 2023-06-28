public class Solution {
    public int FindJudge(int n, int[][] trust) {
        int[] trustees = new int[n + 1];
        
        for(int i = 0; i < trust.Length; i++) {
            trustees[trust[i][0]]--;
            trustees[trust[i][1]]++;
        }

        for(int i = 1; i <= n; i++) {
            if(trustees[i] == n - 1) return i;
        }

        return -1;
    }
}