public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int[] lowest = {prices[0], prices[1]};
        for(int i = 1; i < prices.Length; i++) {
            if(prices[i] < lowest[0]) {
                lowest[1] = lowest[0];
                lowest[0] = prices[i];
            }
            else if(prices[i] < lowest[1])
                lowest[1] = prices[i];
        }
        int diff = money - lowest[0] - lowest[1];
        return (diff >= 0) ? diff : money;
    }
}