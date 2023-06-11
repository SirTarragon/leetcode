public class Solution {
    public int MajorityElement(int[] nums) => nums.OrderBy(n => n).ElementAt(nums.Length / 2);
}