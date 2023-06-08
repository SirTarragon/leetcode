public class Solution {
    public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k) {
        int maxSum = 0;
        for(int i = 0; i < k; i++) {
            if(numOnes > 0) {
                maxSum++;
                numOnes--;
            } else if(numZeros > 0) {
                numZeros--;
            } else if(numNegOnes > 0) {
                maxSum--;
                numNegOnes--;
            }
        }
        return maxSum;
    }
}