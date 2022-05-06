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

    }
}








