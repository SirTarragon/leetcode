public class Solution {
    public int TriangularSum(int[] nums) {
        int n = nums.Length;
        int[] n_nums = nums;
        for(int i = 0; i < n; i++) {
            for(int j = 0; j < (n - i) - 1; j++) {
                n_nums[j] = (n_nums[j] + n_nums[j+1]) % 10;
            }
        }
        return n_nums[0];
    }
}