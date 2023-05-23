public class Solution {
    public int FirstMissingPositive(int[] nums) {
        Dictionary<int, bool> d = new Dictionary<int, bool>();
        int missing = 1;
        foreach(int num in nums)
            if(num >= 0)
                if(!d.ContainsKey(num))
                    d.Add(num, true);
        for(int i = 1; i < Int32.MaxValue; i++)
            if(!d.ContainsKey(i)) {
                missing = i;
                break;
            }
        return missing;
    }
}