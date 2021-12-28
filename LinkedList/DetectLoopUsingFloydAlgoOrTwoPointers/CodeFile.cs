public class SolutionHasCycleLinkedList
{
    public bool HasCycle(ListNode head)
    {
        //Solvin the problem with 2 pointer approach using slow and fast pointer
        var slowPointer = head;
        var fastPointer = head;

        //If first node is null or there is only head node, it means there is no cycle
        while (fastPointer != null && fastPointer.next != null)
        {
            slowPointer = slowPointer.next;//slow pointer will move 1 step
            fastPointer = fastPointer.next.next;//fast pointer will move 2 step ahead

            if (slowPointer == fastPointer)///At some point "fastpointer" will cross "slowpointer"
            {
                return true;
            }
        }
        return false;
    }

}