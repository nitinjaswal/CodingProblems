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
    public class ListNodeDoubly
    {
        public int val;
        public ListNodeDoubly prev;
        public ListNodeDoubly next;
        public ListNodeDoubly child;

        public ListNodeDoubly(int d)
        {
            val = d;
            next = null;
            prev = null;
            child = null;
        }
    }
    public class MyHashSet
    {
        static int[,] matrix = { { 1, 3, 5, 7 },
                        { 10, 11, 16, 20 },
                        { 23, 30, 34, 50 } };
        int K = 3;

        static int[][] arr = new int[][]
           {
               new int[]{1,3,5,7 },
               new int[]{10,11,16,20 },
               new int[]{23,30,34,60},
           };


        public static void Main(String[] args)
        {
            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            int[] nums = { 3, 2, 3 };
            var check = MajorityElement(nums);

        }
        public static IList<int> MajorityElement(int[] nums)
        {
            
            Dictionary<int, int> set = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.ContainsKey(nums[i]))
                {
                    set.Add(nums[i],1);
                }
                else
                {
                    set[nums[i]]++;
                }
            }
            int n = nums.Length / 3;
            var result = set.Where(x => x.Value > n).Select(x=>x.Key).ToList();
            return result;
        }
    }
}










