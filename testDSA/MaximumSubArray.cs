using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCrackDSA
{
    internal class MaximumSubArray
    {
        public MaximumSubArray() { }
        

        public int ReturnMaxiumSubArray(int[] nums)
        {
            int total = 0;
            var result = nums[0];

            for(int i=0; i < nums.Length; i++)
            {
                if(total <0)
                    total = 0;


                total += nums[i];
                result = Math.Max(result, total);
                
            }
            return result;
        }
    }
}
