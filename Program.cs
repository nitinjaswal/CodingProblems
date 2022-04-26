using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
        static Dictionary<int, int> map = new Dictionary<int, int>();
        public static void Main(String[] args)
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            // int index = FirstUniqChar("loveleetcode");
            int result = ClimbStairs(6);

        }

        public static int ClimbStairs(int n)
        {
            if (map.ContainsKey(n))
                return map[n];

            if (n == 0 || n == 1)
            {
                return 1;
            }
            int sum = ClimbStairs(n - 1) + ClimbStairs(n - 2);

            map[n] = sum;
            return sum;
        }
    }

}








