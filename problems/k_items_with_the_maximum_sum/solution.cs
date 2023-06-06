public class Solution {
    public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k) {
        int maxSum = 0;
        for(int i = 0; i < k; i++) {
            if(numOnes-- > 0) {
                maxSum++;
            } else if(numZeros-- > 0) {

            } else if(numNegOnes-- > 0) {
                maxSum--;
            }
        }
        return maxSum;
    }
}