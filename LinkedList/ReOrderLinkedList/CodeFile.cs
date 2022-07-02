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
public class SolutionReorderList
{
    public void ReorderList(ListNode head)
    {
        if (head == null && head.next == null)
        {
            return;
        }
        var currentNode = head;
        var middleNode = GetMiddleNode(head);
        var lastNode = Reverse(middleNode);

        while (currentNode != null && lastNode != null)
        {
            var temp = currentNode.next;
            currentNode.next = lastNode;
            currentNode = temp;

            temp = lastNode.next;
            lastNode.next = currentNode;
            lastNode = temp;
        }
        if (currentNode != null)
        {
            currentNode.next = null;
        }
    }
    private ListNode GetMiddleNode(ListNode head)
    {
        var slowPointer = head;
        var fastPointer = head;
        while (fastPointer != null && fastPointer.next != null)
        {
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;
        }
        return slowPointer;
    }

    private ListNode Reverse(ListNode midNode)
    {
        ListNode previousNode = null;
        var currentNode = midNode;
        while (currentNode != null)
        {
            var temp = currentNode.next;
            currentNode.next = previousNode;
            previousNode = currentNode;
            currentNode = temp;
        }
        return previousNode;
    }
}