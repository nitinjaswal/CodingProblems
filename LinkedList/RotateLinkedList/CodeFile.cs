public class SolutionRotateRight
{
    public class ListNode
    {

        public int val;
        public ListNode next;
        public ListNode random;
        public ListNode(int d)
        {
            val = d;
            next = null;
            random = null;
        }
    }
    public ListNode RotateRight(ListNode head, int k)
    {
        //Edge cases for null
        if (head == null)
        {
            return null;
        }
        if (head.next == null)
        {
            return head;
        }

        //STEP1: First calculate the length of the linked lis
        int length = 1;
        var currentNode = head;
        while (currentNode != null && currentNode.next != null)
        {
            length++;
            currentNode = currentNode.next;
        }

        //STEP2: Point the last node next to the head element,
        //because currentNode is at last and we want to point it to head node
        currentNode.next = head;

        //STEP3: get Length-Kth node and point that to null, becuse we want to break the chain 
        k = k % length;

        k = length - k;
        currentNode = head;
        for (int i = 1; i < k; i++)
        {
            currentNode = currentNode.next;
        }
        head = currentNode.next;
        currentNode.next = null;

        return head;
    }
}