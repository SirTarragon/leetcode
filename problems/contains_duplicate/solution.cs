public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        if(nums.Length == 1) return false;
        var map = new Dictionary<int, byte>();
        for(int i = 0; i < nums.Length; i++) {
            if(map.ContainsKey(nums[i]))
                return true;
            map.Add(nums[i], 1);
        }
        return false;
    }
}