
public class SolutionSwapPairs
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
    public ListNode SwapPairs(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        var dummyNode = new ListNode();
        dummyNode.next = head;
        swap(dummyNode);
        return dummyNode.next;
    }
    void swap(ListNode node)
    {
        if (node == null)
        {
            return;
        }

        ListNode first = node.next;
        ListNode second = null;
        if (first != null)
        {
            second = first.next;
        }

        if (second != null)
        {
            ListNode secondNext = second.next;
            second.next = first;
            node.next = second;
            first.next = secondNext;
            swap(first);
        }
    }
}