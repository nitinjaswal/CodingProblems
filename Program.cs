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
            int[] nums = { 1, 3, 3 };
            int smallestCharacter = FindMin(nums);
        }

        public static int FindMin(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int low = 0;
            int high = nums.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;


                if (nums[mid] > nums[high])
                {
                    low = mid + 1;
                }
                else if (nums[mid] < nums[high]) //
                {
                    high = mid;
                }
                else
                {
                    high = high - 1;
                }
            }
            return nums[low];
        }
    }
}








