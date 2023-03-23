public class Solution {
    public int PivotIndex(int[] nums) {
        int LHS = 0, RHS = 0;
        for(int i = 0; i < nums.Length; i++) {
            for(int j = 0; j < nums.Length; j++) {
                if(j < i) {
                    LHS += nums[j];
                } else if(j > i){
                    RHS += nums[j];
                }
            }

            if(LHS == RHS) {
                return i;
            } else {
                LHS = 0;
                RHS = 0;
            }
        }
        return -1;
    }
}