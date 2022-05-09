public class SolutionDeleteDuplicatesII
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
    public ListNode DeleteDuplicates(ListNode head)
    {
        var dummyNode = new ListNode(0, head);
        var prevNode = dummyNode;
        var currNode = head;
        while (currNode != null)
        {
            if (currNode.next != null && currNode.val == currNode.next.val)
            {
                while (currNode.next != null && currNode.val == currNode.next.val)
                {
                    currNode = currNode.next;
                }
                prevNode.next = currNode.next;
            }
            else
            {
                prevNode = prevNode.next;
            }
            currNode = currNode.next;
        }
        return dummyNode.next;
    }
}