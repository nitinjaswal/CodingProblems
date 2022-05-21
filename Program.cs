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
            int[] nums = { 1, 1, 1, 1, 1 };
            int pivot = SumOfUnique(nums);
            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);
        }
        public static int SumOfUnique(int[] nums)
        {
            var result = 0;
            Dictionary<int,int> set = new Dictionary<int,int>();
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if(!set.ContainsKey(nums[i]))
                {
                    set.Add(nums[i], 1);
                }
                else
                {
                    //if element exist more than once, then update count
                    int oldCount = (int)set[nums[i]];
                    set[nums[i]] = oldCount + 1;
                }
            }
            result = set.Where(x => x.Value == 1).Select(x => x.Key).Sum();
            return result;
        }
    }
}








