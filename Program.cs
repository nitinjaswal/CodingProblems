using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Challenges
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class LinkedList
    {
        public static void Main(String[] args)
        {
            int[] nums = { 3, 4, 3, 2, 1 };
            int index = FindPeakElement(nums);
        }

        public static int FindPeakElement(int[] nums)
        {
            if (nums.Length == 1)
            {
                return 0;
            }

            int low = 0;
            int high = nums.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                //if number in mid is less than its next element, then move towards greater element
                if (nums[mid] < nums[mid + 1])
                {
                    low = mid + 1;
                }
                else //
                {
                    high = mid;
                }
            }
            return low;
        }
    }
}








