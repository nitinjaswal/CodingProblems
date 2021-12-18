using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, -2, 6, 7, -10, -10, 4, 5, 9, -3, 4, 7, -28, 2, 9, 3, 2, 11 };
            int target = 0;
            int index = MaxSubArray(arr);
            //{ 1, 2, 2 };
        }

        public static int MaxSubArray(int[] nums)
        {
            int currentBest = nums[0];
            int overAllBest = nums[0];
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (currentBest < 0)
                {
                    currentBest = nums[i];
                }
                else
                {
                    currentBest = currentBest + nums[i];
                }
                if (currentBest > overAllBest)
                {
                    overAllBest = currentBest;
                }


            }
            return overAllBest;
        }
    }
}



