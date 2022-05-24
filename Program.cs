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

            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);

            int numberToFind = 6;
            int[,] array = new int[3, 3]
            {
                {1, 2, 3 },
                {4,5,6 },
                {7,8,9 }
            };
            int[] arr = new int[] { 2, 3, 3, 4, 3 };
            var list = MajorityElement(arr);

        }

        public static int SingleNumber(int[] nums)
        {
            var result = 0;
            foreach (var num in nums)
            {
                result = result ^ num;
            }
            return result;
        }

        public static int SingleNumberIII(int[] nums)
        {
            var result = 0;
            foreach (var num in nums)
            {
                result = result ^ num;
            }
            return result;
        }

        public static int MajorityElement(int[] nums)
        {
            int res = nums[0];//Be default we are assuming that first element is the majority element
            int count = 1;//Default occurence is 1
            for (int i = 1; i < nums.Length; i++)
            {
                //if number is same then increment its occurence
                if (res == nums[i])
                {
                    count++;
                }//if number is changed,then decrement the occurence of the number
                else
                {
                    count--;
                }

                //if count is zero, means there is no majority element , then take new element as new majority element
                if (count == 0)
                {
                    res = nums[i];
                    count = 1;
                }
            }
            return res;
        }

    }
}








