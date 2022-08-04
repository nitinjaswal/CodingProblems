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
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            int seq = LongestConsecutive(nums);

        }

        public static int LongestConsecutive(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
           

            HashSet<int> set = new HashSet<int>();

            foreach (var item in arr)
            {
                set.Add(item);
            }

            int longestStreak = 0;
            foreach (int num in arr)
            {
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentStreak = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentStreak++;
                        currentNum = currentNum + 1;
                    }
                    longestStreak = Math.Max(currentStreak, longestStreak);
                }
            }
            return longestStreak;
        }
    }
}










