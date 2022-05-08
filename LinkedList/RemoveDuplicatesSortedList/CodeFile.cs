public class LinearSolutionDeleteDuplicates
{
    public ListNode DeleteDuplicates(ListNode head)
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
}