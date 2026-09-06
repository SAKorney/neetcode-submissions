public class Solution {
    public int MaxProfit(int[] prices) {
        int currProfit = 0, profit = 0;
        int buyIdx = 0, sellIdx = 0;
        for (int i = 1; i < prices.Length; i++) {
            currProfit = prices[i] - prices[buyIdx];
            if (currProfit < 0)
            {
                buyIdx = i;
                currProfit = 0;
                continue;                
            }
            
            if (currProfit > profit)
            {
                sellIdx = i;
                profit = currProfit;
            }
        }        
        return profit;
    }
}
