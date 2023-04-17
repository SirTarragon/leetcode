public class Solution {
    public int MissingNumber(int[] nums) {
        int runningSum = 0;
        int numsSum = 0;
        for(int i = 0; i < nums.Length; i++) {
            numsSum += nums[i];
            runningSum += i + 1;
        }
        return runningSum - numsSum;
    }
}