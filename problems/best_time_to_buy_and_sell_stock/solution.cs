public class Solution {
    public int MaxProfit(int[] prices) {
        int val = prices[0];
        int profit = 0;

        foreach(int i in prices) {
            if(i < val)
                val = i;
            if((i-val) > profit)
                profit = i-val;
        }
        
        return profit;
    }
}