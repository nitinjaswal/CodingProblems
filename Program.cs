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
        static ListNode listNode = null;
        public static void Main(String[] args)
        {
            int[] nums = { 3, 6, 1, 0 };
            int pivot = DominantIndex(nums);
            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);
        }
        public static int DominantIndex(int[] nums)
        {
            int largestNum = 0;
            int maxIndex = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] > largestNum)
                {
                    largestNum = nums[i];
                    maxIndex = i;
                }
            }
            bool islargest = false;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] != largestNum && nums[i] * 2 > largestNum)
                {
                    islargest = false;
                    return -1;
                }
                else
                {
                    islargest = true;
                }
            }           

            if (islargest)
            {
                return maxIndex;
            }
            else
            {
                return -1;
            }

        }
    }
}








