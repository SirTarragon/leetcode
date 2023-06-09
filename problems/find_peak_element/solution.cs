public class Solution {
    public int FindPeakElement(int[] nums) {
        int start = 0, end = nums.Length - 1, mid;
        while(start < end) {
            mid = start + (end - start) / 2;
            if(nums[mid] > nums[mid + 1]) {
                end = mid;
            } else
                start = mid + 1;
        }
        return start;
    }
}