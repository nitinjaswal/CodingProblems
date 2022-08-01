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
               new int[]{7,34,45,10,12,27,13 },
               new int[]{27,21,45,10,12,13 },
               //new int[]{3,4,5,6 },
           };


        public static void Main(String[] args)
        {
            //ListNode node = new ListNode(1);
            //node.next = new ListNode(2);

            var list = Intersection(arr);
        }

        public static IList<int> Intersection(int[][] nums)
        {
            int row = nums.Length;
            int col = nums[0].Length;

            Dictionary<int, int> set = new Dictionary<int, int>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    if (!set.ContainsKey(nums[i][j]))
                    {
                        set.Add(nums[i][j], 1);
                    }
                    else
                    {
                        set[nums[i][j]]++;
                    }
                }
            }
            var result = set.Where(x => x.Value == nums.Length).Select(x => x.Key).OrderBy(x => x);
            return result.ToList();
        }
    }
}











