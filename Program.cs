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
            var list = MergeTwoLists(node, node1);
        }
        public ListNode DetectCycle(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = head;
            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
                if (slowPointer == fastPointer)
                {
                    //There is a loop
                    slowPointer = head;
                    while (slowPointer != fastPointer)
                    {
                        slowPointer = slowPointer.next;
                        fastPointer = fastPointer.next;
                    }
                    return slowPointer;
                }
            }
            return null;
        }
        public bool HasCycle(ListNode head)
        {
            var slowPointer = head;
            var fastPointer = head;
            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
                if (slowPointer == fastPointer)
                {
                    return true;
                }
            }
            return false;
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var dummyNode = new ListNode(0);
            var head = dummyNode;

            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    dummyNode.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    dummyNode.next = l2;

                    l2 = l2.next;
                }
                dummyNode = dummyNode.next;
            }

            //while (l1 != null)
            //{
            //    dummyNode.next = l1;
            //    dummyNode = dummyNode.next;
            //    l1 = l1.next;
            //}
            //while (l2 != null)
            //{
            //    dummyNode.next = l2;
            //    dummyNode = dummyNode.next;
            //    l2 = l2.next;
            //}
            dummyNode.next = l1 == null ? l2 : l1;
            return head.next;

        }
        private static ListNode DeleteDuplicatesUnsortedList(ListNode head)
        {
            var currentNode = head;
            var previousNode = new ListNode(0);
            HashSet<int> map = new HashSet<int>();
            while (currentNode != null)
            {
                if (!map.Contains(currentNode.val))
                {
                    map.Add(currentNode.val);
                    previousNode = currentNode;
                }
                else
                {
                    previousNode.next = currentNode.next;
                }
                currentNode = currentNode.next;
            }
            return head;
        }
        private static ListNode DeleteDuplicatesSortedList(ListNode head)
        {
            var currentNode = head;
            while (currentNode != null && currentNode.next != null)
            {
                if (currentNode.val == currentNode.next.val)
                {
                    currentNode.next = currentNode.next.next;
                }
                else
                {
                    currentNode = currentNode.next;
                }
            }
            return head;
        }
        private static void Insert(ListNode rootNode, int index, int val)
        {
            var currentNode = rootNode;
            for (int i = 0; i < index - 1; i++)
            {
                currentNode = currentNode.next;
            }
            var temp = currentNode.next;
            currentNode.next = new ListNode(7);
            currentNode.next.next = temp;
        }

        private static ListNode InsertUsingRecursion(ListNode rootNode, int index, int val)
        {
            if (index == 0)
            {
                ListNode temp = new ListNode(val, rootNode);
                return temp;
            }
            rootNode.next = InsertUsingRecursion(rootNode.next, index: index - 1, val);
            return rootNode;

            //if (index == 1)
            //{
            //    var temp = rootNode.next;
            //    rootNode.next = new ListNode(7);
            //    rootNode.next.next = temp;
            //    return;
            //}
            //InsertUsingRecursion(rootNode.next, index: index - 1, val);
        }
    }

}











