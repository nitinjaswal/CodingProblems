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
            int[] nums = { 4,8,9,9 };
            var array = PlusOne(nums);
            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);
        }
        public static int[] PlusOne(int[] digits)
        {

            int n = digits.Length;
            for (int i = n - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i] = digits[i] + 1;
                    break;
                }
                else
                {
                    digits[i] = 0;
                }
            }
            if (digits[0] == 0)
            {
                int[] result = new int[n + 1];
                result[0] = 1;
                return result;
            }
            return digits;
        }
    }
}








