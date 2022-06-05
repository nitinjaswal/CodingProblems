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



    public class MyHashSet
    {
        static int[,] matrix = { { 1, 3, 5, 7 },
                        { 10, 11, 16, 20 },
                        { 23, 30, 34, 50 } };
        int K = 3;

        static int[][] arr = new int[][]
           {
                new int[] {1, 2, 3, 4},
                new int[] {11, 34, 67},
                new int[] {89, 23},
                new int[] {0, 45, 78, 53, 99}
          };
        public static void Main(String[] args)
        {
            // SearchMatrix(arr, 3);
            var p = new TreeNode(10);
            //p.left = new TreeNode(5);
            //p.right = new TreeNode(15);

            var q = new TreeNode(10);
            //q.left = new TreeNode(5);
            q.right = new TreeNode(2);
            bool isSame = IsSameTree(p, q);
        }

        public static string AddBinary(string a, string b)
        {
            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(b);
            int sum = 0;
            int i = a.Length;
            int j = b.Length;
            int carry = 0;
            //while (i >= 0 && j >= 0)
            //{
            //    if (a[i] + b[j] >= 1)
            //}
            return "";
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;

            if (q == null || p == null) return false;
            if (p.val != q.val)
            {
                return false;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(p);
            queue.Enqueue(q);
            while (queue.Count > 0)
            {
                var itemP = queue.Peek();
                queue.Dequeue();
                var itemQ = queue.Peek();
                queue.Dequeue();
                if (itemP == null && itemQ == null)
                {
                    continue;
                }
                if (itemP != null && itemQ == null)
                {
                    return false;
                }
                if (itemP == null && itemQ != null)
                {
                    return false;
                }
                if (itemP.val != itemQ.val)
                {
                    return false;
                }
                else
                {
                    queue.Enqueue(itemP.left);
                    queue.Enqueue(itemQ.left);
                    queue.Enqueue(itemP.right);
                    queue.Enqueue(itemQ.right);
                }
            }

            return true;
        }
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i][j] == target)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
    }

}









