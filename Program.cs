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
            int[] arr = { 1 };
            int target = 0;
            int index = SearchInsert(arr, target);
            //{ 1, 2, 2 };
        }

        public static int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                if (target > nums[mid])
                {
                    low = mid + 1;
                    index = low;
                }
                else
                {
                    index = mid;
                    high = mid - 1;                

                }
            }
            return index;

        }
    }
}



