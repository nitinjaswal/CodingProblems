public class SolutionRemoveNthFromEnd
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        //Created dummy node which will poin to Head node
        var dummyNode = new Node(0);
        dummyNode.next = head;

        var fastPointer = dummyNode;
        var slowPointer = dummyNode;

        //Ww will move faster pointer to nth position in list. Herre we are moving it to N+1 because we are starting from dummy node
        for (int i = 1; i <= n + 1; i++)
        {
            fastPointer = fastPointer.next;
        }

        //Now fast pointer is at Nth position
        //Move slow and fast pointer one step each. 
        //The moment fast pointer reaches tail, we will get slowPointerNext (node to be deleted) and point to next.next
        while (fastPointer != null)
        {
            fastPointer = fastPointer.next;
            slowPointer = slowPointer.next;
        }

        slowPointer.next = slowPointer.next.next;
        return dummyNode.next;
    }

}