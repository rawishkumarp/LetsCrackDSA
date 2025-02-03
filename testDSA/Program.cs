using LetsCrackDSA;
using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace CrackDSA
{
    public class Program
    {
        static void Main(string[] args)
        {
            //H2OWaterProblem(); //https://leetcode.com/problems/building-h2o/description/ 

            //MinStack(); // https://leetcode.com/problems/min-stack/description/ 

            //TwoSum();

            //MaxProfit();

            //ContainsDuplicate();

            //HouseRobber();


            char[] s = new char[] { 'h', 'e', 'l', 'l', 'o' };
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                left++;
                s[right] = temp;
                right--;
            }




        }

        private static void H2OWaterProblem()
        {
            H20 h2o = new H20();

            Action releaseHydrogen = () => Console.Write("H");
            Action releaseOxygen = () => Console.Write("O");

            string input = "OOHHHH";
            Task[] tasks = new Task[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'H')
                {
                    tasks[i] = Task.Run(() => h2o.Hydrogen(releaseHydrogen));
                }
                else if (input[i] == 'O')
                {
                    tasks[i] = Task.Run(() => h2o.Oxygen(releaseOxygen));
                }
            }

            Task.WaitAll(tasks);
        }

        private static void MinStack()
        {
            MinStack stack = new MinStack();
            stack.Push(-2);
            stack.Push(0);
            stack.Push(-3);
            Console.WriteLine(stack.GetMin()); // Returns -3
            stack.Pop();
            Console.WriteLine(stack.Pop);    // Returns 0
            Console.WriteLine(stack.GetMin()); // Returns -2
        }

        private static void TwoSum()
        {
            int[] nums = { 2, 4, 5, 6, 7, 7 };
            int target = 11;
            int[] result = new TwoSum().TwoSumProblem(nums, target);
            Console.WriteLine($"Indices: {result[0]}, {result[1]}");
        }

        private static void MaxProfit()
        {
            int[] prices = { 2, 4, 5, 6, 7, 7 };
            int result = new MaxProfit().GetMaxProfile(prices);
        }

        private static void ContainsDuplicate()
        {
            int[] nums = { 2, 4, 5, 6, 6, 9 };
            bool result = new ContainsDuplicate().DuplicatesInArrary(nums);
        }
        private static void HouseRobber()
        {
            int[] nums = { 2, 7, 9, 3, 1 };
            int result = new HouseRobber().BestHouseRoberry(nums);
            Console.WriteLine($"Max amount robbed: {result}");
        }
    }
}