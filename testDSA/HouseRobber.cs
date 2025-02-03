using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace LetsCrackDSA
{
    internal class HouseRobber
    {

        //[2,7,9,3,1]

        public HouseRobber()
        { }

        public int BestHouseRoberry(int[] nums)

        {
            var maxMoney = 0;
            var preMoney = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int temp = Math.Max(maxMoney, preMoney + nums[i]);
                preMoney = maxMoney;
                maxMoney = temp; 
            }

            return maxMoney;

        }
    }
}
