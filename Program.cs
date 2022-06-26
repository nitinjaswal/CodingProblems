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
                new int[] {1, 2, 3},
                new int[] {11, 34, 67},
                new int[] {89, 23,33}
          };
        public static void Main(String[] args)
        {

            ListNode node = new ListNode(1);
            node.next = new ListNode(2);
            node.next.next = new ListNode(4);

            ListNode node1 = new ListNode(1);
            node1.next = new ListNode(3);
            node1.next.next = new ListNode(4);
            //var root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);
            //root.left.right = null;
            //root.left.left = null;
            //root.right.right = new TreeNode(7);
            //root.right.left = new TreeNode(15);
            //var list = InsertUsingRecursion(node, 3, 7);
            bool isHappyNumber = IsHappy(19);
        }

        private static bool IsHappy(int n)
        {
            //using o(n) without extra space: Slow and fast pointer
            int slow = n;
            int fast = n;
            do
            {
                slow = GetSquare(slow);
                fast = GetSquare(GetSquare(fast));               
            }
            while (slow != fast) ;
            if (slow == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int GetSquare(int n)
        {
            int result = 0;
            while (n > 0)
            {
                int digit = n % 10;
                n = n / 10;
                result = result + (digit * digit);
            }
            return result;
        }

    }

}











