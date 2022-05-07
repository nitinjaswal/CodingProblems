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
            int[] nums = { 3, 1, 3, 4, 2 };
            var list = FindDuplicate(nums);
        }

        public static int FindDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if(nums[i]==nums[i+1])
                {
                    return nums[i];
                }
            }
            return -1;
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            var output = new List<int>();
            int low = 0;
            int high = numbers.Length - 1;
            while (low < high)
            {
                int sum = numbers[low] + numbers[high];
                if (sum == target)
                {
                    output.Add(low + 1);
                    output.Add(high + 1);
                    return output.ToArray();
                }
                else if (sum > target)
                {
                    high--;
                }
                else
                {
                    low++;
                }
            }
            return output.ToArray();
        }
    }
}








