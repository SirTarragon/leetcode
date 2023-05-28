public class Solution {
    public int RepeatedNTimes(int[] nums) {
        var d = new Dictionary<int,byte>();
        int output = -1;
        foreach(int num in nums)
            if(d.ContainsKey(num)) {
                output = num; break;
            }
            else
                d.Add(num, 1);
        return output;
    }
}