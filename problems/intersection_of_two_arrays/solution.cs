public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        Dictionary<int, int> map = new Dictionary<int,int>();
        List<int> intersect = new List<int>();

        for(int i = 0; i < nums1.Length; i++) {
            if(map.ContainsKey(nums1[i]))
                map[nums1[i]]++;
            else
                map.Add(nums1[i], 1);
        }

        for(int i = 0; i < nums2.Length; i++) {
            if(map.ContainsKey(nums2[i])) {
                intersect.Add(nums2[i]);
                map.Remove(nums2[i]);
            }
        }

        return intersect.ToArray();        
    }
}