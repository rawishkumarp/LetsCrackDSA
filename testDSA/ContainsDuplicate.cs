using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsCrackDSA
{
    internal class ContainsDuplicate
    {
        /// <summary>
        /// A HashSet to store unique integers.
        /// </summary>
        private HashSet<int> hashSet;

        /// <summary>
        /// Initializes a new instance of the ContainsDuplicate class.
        /// </summary>
        public ContainsDuplicate()
        {
            hashSet = new HashSet<int>();
        }

        /// <returns>True if duplicates are found, otherwise false.</returns>
        public bool DuplicatesInArrary(int[] nums)
        {
            // Iterate through each element in the array
            for (int i = 0; i < nums.Length; i++)
            {
                // Check if the current element already exists in the HashSet
                if (hashSet.Contains(nums[i]))
                {
                    // If it exists, a duplicate is found, return true
                    return true;
                }
                else
                {
                    // If it does not exist, add the element to the HashSet
                    hashSet.Add(nums[i]);
                }
            }

            // If no duplicates are found after checking all elements, return false
            return false;
        }
    }
}
