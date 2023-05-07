public class Solution {
    public bool CanJump(int[] nums) {       
        for(int i = 0, j = 0; i < nums.Length; i++, j--) {
            if(nums[i] > j)
                j = nums[i];
            if(nums[i] + i >= nums.Length - 1)
                return true;
            else if(nums[i] == 0 && j == 0)
                return false;
        }
        
        return true;
    }
}