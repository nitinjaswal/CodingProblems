using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenges.Queue.ShortestDistance;

namespace Challenges
{
    public class TreeNode
    {
        public int val;
        public TreeNode left, right;

        public TreeNode(int item)
        {
            val = item;
            left = right = null;
        }
    }
    class LinkedList
    {
        static ArrayList list = new ArrayList();
        public static void Main(String[] args)
        {
            int[] arr = { 3, 2, 18, 18, 9 };
            var index = FindAllIndex(arr, 18, 0,list);        }

       

        static ArrayList FindAllIndex(int[] arr, int target, int i, ArrayList list)
        {
            if (i == arr.Length)
            {
                return list;
            }
            if (arr[i] == target)
            {
                list.Add(i);
            }
            return FindAllIndex(arr, target, i + 1, list);
        }

        static int FindIndex(int[] arr, int target, int i)
        {
            if (i == arr.Length)
            {
                return -1;
            }
            if (arr[i] == target)
            {
                return i;
            }
            else
            {
                return FindIndex(arr, target, i + 1);
            }
        }
    }

}








