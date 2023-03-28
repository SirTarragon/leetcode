public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] combined = MergeTwoSortedArrays(nums1, nums2);

        int middleIndex = (int)Math.Ceiling((double)(combined.Length/2));
        if(combined.Length % 2 != 0) {
            return (double)combined[middleIndex];
        }
        return (double)(combined[middleIndex-1] + combined[middleIndex])/2;
    }

    public static int[] MergeTwoSortedArrays(int[] arr1, int[] arr2) {
			int n = arr1.Length;
			int m = arr2.Length;
			int[] merge = new int[n + m];
			int i = 0, j = 0, k = 0;
			while (i < n && j < m) {
				if (arr1[i] < arr2[j]) {
					merge[k] = arr1[i];
					i++;
					k++;
				} else {
					merge[k] = arr2[j];
					j++;
					k++;
				}
			}
			while (i < n) {
				merge[k] = arr1[i];
				i++;
				k++;
			}
			while (j < m) {
				merge[k] = arr2[j];
				j++;
				k++;
			}
			return merge;
	}
}