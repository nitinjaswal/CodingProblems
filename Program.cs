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
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            int pivot = PivotIndex(nums);
            listNode = new ListNode(1);  
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);
        }
        public static int PivotIndex(int[] nums)
        {
            int totalSum = 0;
            int leftSum = 0;

            for (int i = 0; i <= nums.Length - 1; i++)
            {
                totalSum = totalSum + (nums[i]);
            }
            int rightSum = totalSum;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                rightSum = rightSum - nums[i];
                if (leftSum == rightSum)
                {
                    return i;
                }
                else
                {
                    leftSum = leftSum + nums[i];
                }
            }
            return -1;
        }
    }
}








