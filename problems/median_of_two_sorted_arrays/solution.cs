public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combined = new int[nums1.Length + nums2.Length];
        Array.Copy(nums1, combined, nums1.Length);
        Array.Copy(nums2, 0, combined, nums1.Length, nums2.Length);
        Array.Sort(combined);

        int middleIndex = (int)Math.Ceiling((double)(combined.Length/2));
        if(combined.Length % 2 != 0) {
            return (double)combined[middleIndex];
        }
        return (double)(combined[middleIndex-1] + combined[middleIndex])/2;
    }
}