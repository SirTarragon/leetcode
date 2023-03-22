public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSum=-10000;
        int sum=0;

        for(int i=0; i < nums.Length; i++){
            sum+=nums[i];

            if(sum > maxSum) maxSum=sum;
            if(sum < 0) sum=0;
        }
        return maxSum;
    }
}