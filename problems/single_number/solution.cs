public class Solution {
    public int SingleNumber(int[] nums) {
        int r = 0;
        foreach(int x in nums)
            r ^= x;
        return r;
    }
}