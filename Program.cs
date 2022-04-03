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
        static List<List<int>> output = new List<List<int>>();
        public static void Main(String[] args)
        {
            int[] nums1 = { 1,2,2,1 };
            int[] nums2 = { 2,2 };
            var array = Intersect(nums1, nums2);

        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            HashSet<int> set = new HashSet<int>();

            int count = 0;
            foreach (int i in nums1)
            {
                set.Add(i);
            }

            HashSet<int> intersection = new HashSet<int>();

            foreach(int i in nums2)
            {
                if(set.Contains(i))
                {
                    intersection.Add(i);
                }
            }
            //int[] intersectedArray = new int[intersection.Count];
            //for (int i = 0; i <= intersectedArray.Length - 1; i++)
            //{
            //   intersectedArray[i] = intersection.ToArray();
            //}
            /* return intersection.ToArray(); */
            ;
         //   return intersection.ToArray();
            return null;
        }

    }

}








