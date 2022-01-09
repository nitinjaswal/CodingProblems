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
public class SolutionIsPalindrome
{
    Node head, head2;

    public class Node
    {

        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    public bool IsPalindrome(Node head)
    {
        //In brute force we can simply reverse a linked list and compare both the linked list
        // it will tak extra space
        //Solution in O(N) and O(1) space: Reverse second half of linked list and start comparing first and last element 

        if (head == null)
        {
            return true;
        }
        var currentNode = head;//1->2
        var middleNode = MiddleElement(head);//it will find middle element in the list
        var lastNode = ReverseList(middleNode);//it contains second half of the list in reverse order (2->1 will become NULL<-2<-1)

        while (lastNode != null)
        {
            if (lastNode.data != currentNode.data)
            {
                return false;
            }
            else
            {
                currentNode = currentNode.next;
                lastNode = lastNode.next;
            }
        }
        return true;
    }

    private Node MiddleElement(Node head)
    {
        //To check middle element in linked list we use slow and fast pointer(it will move by 2 steps)
        var slowPointer = head;
        var fastPointer = head;
        while (fastPointer != null && fastPointer.next != null)
        {
            fastPointer = fastPointer.next.next;
            slowPointer = slowPointer.next;
        }

        return slowPointer;
    }

    private Node ReverseList(Node head)
    {
        //1->2->3->5

        //After reverse:   NULL<-1<-2<-3<-4<-5
        Node previuosNode = null;
        Node currentNode = head;

        while (currentNode != null)
        {
            var temp = currentNode.next;//before updating, we need to store it in some temp variable
            currentNode.next = previuosNode;//First it will point to NULL(as previuosNode is set to NULL initially)
            previuosNode = currentNode;
            currentNode = temp;

        }
        return previuosNode;

    }
}
    