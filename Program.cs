using System;

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
        public static void Main(String[] args)
        {
            ListNode head = new ListNode(4);
            head.next = new ListNode(3);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(1);
            head.next.next.next.next = new ListNode(-1);

            var list = MergeSort(head);
        }

        private static ListNode MiddleElement(ListNode head)
        {
            //To check middle element in linked list we use slow and fast pointer(it will move by 2 steps)
            var slowPointer = head;
            var fastPointer = head.next;
            while (fastPointer != null && fastPointer.next != null)
            {
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }

            return slowPointer;
        }

        public static ListNode MergeSort(ListNode head)
        {
            if(head == null || head.next==null)
            {
                return head;
            }
            //breaking list into 2 parts after finding mid element
            var midNode = MiddleElement(head);
            var leftList = head;
            var rightList = midNode.next;
            midNode.next = null;

            //recursive calls to sort
            leftList = MergeSort(leftList);
            rightList = MergeSort(rightList);

            //Merge 2 sorted lists
            var result = MergeTwoLists(leftList, rightList);
            return result;
        }

        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var dummyNode = head;
            var list1 = l1;
            var list2 = l2;

            //if first list is empty then return second list and vice versa
            if (l1 == null)
            {
                return l2;
            }
            if (l2 == null)
            {
                return l1;
            }
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    dummyNode.next = list1;
                    dummyNode = dummyNode.next;
                    list1 = list1.next;
                }
                else
                {
                    dummyNode.next = list2;
                    dummyNode = dummyNode.next;
                    list2 = list2.next;
                }
            }

            while (list1 != null)
            {
                dummyNode.next = list1;
                dummyNode = dummyNode.next;
                list1 = list1.next;
            }
            while (list2 != null)
            {
                dummyNode.next = list2;
                dummyNode = dummyNode.next;
                list2 = list2.next;
            }
            return head.next;
        }
    }

}








