using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCrackDSA
{
    internal class TwoSum
    {
        private Dictionary<int, int> map;

        public TwoSum()
        {
            map = new Dictionary<int, int>();
        }

        public int[] TwoSumProblem(int[] nums, int target)
        {
            map.Clear(); // Clear the map to avoid conflicts with previous data  
            var length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                var curr = nums[i];
                int x = target - curr;
                if (map.ContainsKey(x))
                {
                    return new int[] { map[x], i };
                }

                if (!map.ContainsKey(curr))
                {
                    map.Add(curr, i);
                }
            }

            return new int[0];
        }
    }
}
