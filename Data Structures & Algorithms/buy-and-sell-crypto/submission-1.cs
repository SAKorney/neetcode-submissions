public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int minPrice = prices[0];
        foreach (var price in prices) {
            maxProfit = Math.Max(price - minPrice, maxProfit);
            minPrice = Math.Min(minPrice, price);
        }
        return maxProfit;
    }
}
