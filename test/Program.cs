using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInput = { 1 };
            Console.WriteLine(Solution.SingleNumber(arrInput));


        }
    }

    public static class Solution
    {
        /*public static int FirstUniqChar(string s)
        {
            string someString = "";
            int[] result = 0;

            foreach (char item in s)
            {
                if (someString.Contains(item))
                {
                    continue;
                    result = 0;
                }
                else
                {
                    someString += item;
                 
                }
            }

            if (result != 0)
            {
                return result;
            }

            return -1;
        }*/

        public static int SingleNumber(int[] nums)
        {
            Array.Sort(nums);

            for(int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1] && nums[i] == nums[i - 1])
                {
                    continue;
                }
            }

            if(nums.Length > 1)
            {
                if (nums[0] != nums[1])
                {
                    return nums[0];
                }

                else if (nums[nums.Length - 1] != nums[nums.Length - 2])
                {
                    return nums[nums.Length - 1];
                }

                return -1;
            }
            return nums[0];
        }
    }
}
