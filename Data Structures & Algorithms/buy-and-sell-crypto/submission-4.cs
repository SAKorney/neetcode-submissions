public class Solution {
    // Two Pointers
    public int MaxProfit(int[] prices) {
        int profit = 0;
        int l = 0;
        int r = 1;
        while (r < prices.Length) {            
            if (prices[l] < prices[r]) {
                int p = prices[r] - prices[l];
                profit = Math.Max(profit, p);
            } else {
                l = r;
            }
            r++;
        }
        return profit;
    }
}
