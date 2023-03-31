public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0, high = nums.Length - 1, middle;
        while(low < high) {
            middle = low + (int)Math.Floor((double)(high - low + 1)/2);
            if(target < nums[middle]) {
                high = middle - 1;
            }
            else {
                low = middle;
            }
        }
        return (nums[low] == target) ? low : -1; 
    }
}