public class Solution {
    public int MaxProfit(int[] prices) {

        // Declare processing variables to store the highest profit found and the minimum price of the stocks
        int highestProfit = 0;
        int minimumBuyPrice = prices[0];

        // Iterate through each day of prices
        foreach (int day in prices)
        {
            // Determine if today's price is lower than the currently stored lowest day
            minimumBuyPrice = Math.Min(minimumBuyPrice, day);
            // Determine if the profit margin for today compared to the lowest buy price is higher than the currently stored profit
            highestProfit = Math.Max(highestProfit, day - minimumBuyPrice);

        }

        // Return the highest profit found
        return highestProfit;
        
    }
}