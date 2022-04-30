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
        static Dictionary<int, int> map = new Dictionary<int, int>();
        public static void Main(String[] args)
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            // int index = FirstUniqChar("loveleetcode");

            int length = MySqrt(8);
        }


        public static int MySqrt(int x)
        {
            if (x < 2)
            {
                return x;
            }

            long low = 0;
            long high = x;
            long mid = 0;
            while (low <= high)
            {
                mid = low + ((high - low) / 2);
                long square = mid * mid;
                if (square == x)
                {
                    return (int)mid;
                }
                else if (square > x)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return (int)high;
        }
    }

}








