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
            int[] nums = { 5, 7, 7, 8, 8, 10 };
            var index = SearchRange(nums, 8);
        }

        public static int[] SearchRange(int[] nums, int target)
        {
           
            int low = 0;
            int high = nums.Length - 1;

            int firstIndex = ReturnFirstIndex(nums, target);
            int lastIndex = ReturnLastIndex(nums, target);
            int[] arr = { firstIndex, lastIndex };
            return arr;

        }

        private static int ReturnFirstIndex(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int index = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] >= target)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
                if (nums[mid] == target)
                {
                    index = mid;
                }
            }
            return index;
        }
        private static int ReturnLastIndex(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;
            int index = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (nums[mid] <= target)            
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
                if (nums[mid] == target)
                {
                    index = mid;
                }
            }
            return index;
        }
    }
}








