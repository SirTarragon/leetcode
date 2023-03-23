public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int length = nums.Count();
        for(int i =0;i< length;i++) {
            if(map.ContainsKey(nums[i])) {
                GC.Collect();
                return new int[]{map[nums[i]],i};
            }
            int number = target - nums[i];
            if(!map.ContainsKey(number)) map.Add(number,i);
        }
        return new int[1];
    }
}