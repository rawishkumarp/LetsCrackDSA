using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LetsCrackDSA
{
    internal class MaxProfit
    {
        public MaxProfit()
        {

        }

        /// <summary>
        /// Calculates the maximum profit that can be achieved from buying and selling stock.
        /// </summary>
        /// <param name="prices">An array of stock prices where prices[i] is the price of the stock on the i-th day.</param>
        /// <returns>The maximum profit that can be achieved.</returns>
        public int GetMaxProfile(int[] prices)
        {
            var buyPrice = prices[0];
            var maxProfit = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (buyPrice > prices[i])
                {
                    buyPrice = prices[i];
                }
                maxProfit = Math.Max(maxProfit, prices[i] - buyPrice);
            }
            return maxProfit;
        }
    }
}
