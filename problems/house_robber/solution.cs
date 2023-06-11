public class Solution {
    public int Rob(int[] nums) {
        int max = nums[0], s = 0;
        for(int i = 1; i < nums.Length; i++)
            (max, s) = (Math.Max(nums[i] + s, max), max);
        return max;
    }
}