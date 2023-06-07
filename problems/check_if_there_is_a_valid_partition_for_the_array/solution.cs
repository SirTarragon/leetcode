public class Solution {
    public bool ValidPartition(int[] nums) {
        int n = nums.Length;
        // base case
        if (n == 2) {
            return nums[0] == nums[1];
        }
        // set initial value
        bool[] dp = new bool[n + 1];
        if (nums[0] == nums[1]) {
            dp[1] = true;
        }
        if ((nums[0] == nums[1] && nums[1] == nums[2]) ||
        (nums[0] + 1 == nums[1] && nums[1] + 1 == nums[2])) {
            dp[2] = true;
        }
        // update the dp table
        for (int i = 3; i < n; i++) {
            if (nums[i] == nums[i - 1]) {
                dp[i] |= dp[i - 2];
            }
            if (nums[i] == nums[i - 1] && nums[i - 1] == nums[i - 2]) {
                dp[i] |= dp[i - 3];
            }
            if (nums[i] - 1 == nums[i - 1] && nums[i - 1] - 1 == nums[i - 2]) {
                dp[i] |= dp[i - 3];
            }
        }
        return dp[n - 1];
    }
}