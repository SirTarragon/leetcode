class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int profit = 0;
        int val = prices[0];
        for(int i = 0; i < prices.size(); i++) {
            if(prices[i] < val) {
                val = prices[i];
            }
            if(prices[i] - val > profit) {
                profit = prices[i] - val;
            }
        }
        return profit;
    }
};