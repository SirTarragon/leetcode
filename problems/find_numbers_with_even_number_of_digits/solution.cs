public class Solution {
    public int FindNumbers(int[] nums) {
        int evenCount = 0;
        foreach(int num in nums) {
            if(num.ToString().Length % 2 == 0)
                evenCount++;
        }       
        return evenCount;
    }
}