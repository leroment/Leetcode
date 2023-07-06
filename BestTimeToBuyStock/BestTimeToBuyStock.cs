public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 1)
        {
            return 0;
        }

        int lowestPrice = prices[0];
        int potentialMaxProfit = 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < lowestPrice)
            {
                lowestPrice = prices[i];
            }

            if (prices[i] > lowestPrice)
            {
                if ((prices[i] - lowestPrice) > potentialMaxProfit)
                {
                    potentialMaxProfit = prices[i] - lowestPrice;
                }
            }
        }

        return potentialMaxProfit;
    }
}