public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = prices[0];
        for (int i = 0; i < prices.Length; i++) {
            maxProfit = Math.Max(prices[i] - minPrice, maxProfit);
            minPrice = Math.Min(prices[i], minPrice);
        }
        return maxProfit;
    }
}
