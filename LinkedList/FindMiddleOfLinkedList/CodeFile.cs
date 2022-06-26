
public class SolutionMiddleNode
{
    public ListNode MiddleNode(ListNode head)
    {
        //Using SLow and fast pointer
        var slowPointer = head;
        var fastPointer = head;
        while (fastPointer != null && fastPointer.next != null)
        {
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;
        }
        return slowPointer;
    }
}