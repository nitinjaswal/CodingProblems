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
               new int[]{1,5,9 },
               new int[]{10,11,13 },
               new int[]{12,13,15},
           };


        public static void Main(String[] args)
        {
            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);
            int[] nums = { 1, 2, 1 };
            var array = GetConcatenation(nums);


        }

        public static int[] GetConcatenation(int[] nums)
        {
            int[] newArray = new int[nums.Length * 2];
            for (int i = 0; i < nums.Length; i++)
            {
                newArray[i] = nums[i];
                newArray[i + nums.Length] = nums[i];
            }

            return newArray;
        }

    }
}










