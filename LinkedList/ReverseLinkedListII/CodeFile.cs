/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */


public class SolutionReverseBetween
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
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (left == right)
        {
            return head;
        }

        var dummyNode = new ListNode(0, head);
        //skip the first left-1 nodes

        ListNode previousNodeBeforeReverse = dummyNode;
        ListNode currentNode = head;
        for (int i = 1; i < left; i++)
        {
            previousNodeBeforeReverse = currentNode;
            currentNode = currentNode.next;
        }

        ListNode previousNode = null;
        for (int i = left; i <= right; i++)
        {
            var temp = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
        }

        previousNodeBeforeReverse.next.next = currentNode;
        previousNodeBeforeReverse.next = previousNode;
        return dummyNode.next;
    }

    //This code not working
    public ListNode ReverseBetweenNotWorking(ListNode head, int left, int right)
    {
        if (left == right)
        {
            return head;
        }

        //skip the first left-1 nodes

        ListNode previousNodeBeforeReverse = null;
        ListNode currentNode = head;
        for (int i = 1; i < left; i++)
        {
            previousNodeBeforeReverse = currentNode;
            currentNode = currentNode.next;
        }

        //Reverse list
        //previousNode = null;
        ListNode previousNode = null;
        for (int i = left; i <= right; i++)
        {
            var temp = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
        }
        previousNodeBeforeReverse.next.next = currentNode;
        previousNodeBeforeReverse.next = previousNode;
        return previousNodeBeforeReverse;
    }
}