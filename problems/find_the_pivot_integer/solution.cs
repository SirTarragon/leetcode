public class Solution {
    public int PivotInteger(int n) {
        int RHS = 0, LHS = Enumerable.Range(1,n).Aggregate((a,b) => a + b);
        for(int j = n; j > 0; j--)
        {
            RHS += j;
            if(RHS == LHS) return j;
            LHS -= j;
        }
        return -1;
    }
}

