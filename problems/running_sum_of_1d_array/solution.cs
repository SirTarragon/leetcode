public class Solution {
    public int[] RunningSum(int[] nums) {
        List<int> runningSum = new List<int>();
        int sum = 0;
        foreach(int x in nums ) {
            sum += x;
            runningSum.Add(sum);
        }
        return runningSum.ToArray();
    }
}