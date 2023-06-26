public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);        
        int maxLen = 1, currLen = 1;        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] != nums[i-1]) {
                if (nums[i] == nums[i-1]+1) {
                    currLen++;
                } else {
                    maxLen = Math.Max(maxLen, currLen);
                    currLen = 1;
                }
            }
        }        
        return Math.Max(maxLen, currLen);
    }
}