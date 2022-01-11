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
public class SolutionAddTwoNumbers
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode dummyNode = new ListNode(0);
        ListNode list1 = l1, list2 = l2;
        ListNode currentNode = dummyNode;
        int carry = 0;

        //Loop on both the lists till null
        while (list1 != null || list2 != null)
        {
            int x = 0;
            int y = 0;
            if (list1 != null)
            {
                //storing value of node in x
                x = list1.val;
            }
            if (list2 != null)
            {
                //storing value of node in y
                y = list2.val;
            }

            //Adding individual element of both list one by one. Adding carry so that if there is any
            //By default carry is 0. update carry with the sum/10, to get carry
            int sum = x + y + carry;
            carry = sum / 10;

            //Now currenNode.next will point to the sum of 2 numbers without carry and sum is sum%10
            //e.g 7+3=10, sum%10=0, carry =1
            currentNode.next = new ListNode(sum % 10);
            currentNode = currentNode.next;

            if (list1 != null)
            {
                list1 = list1.next;
            }
            if (list2 != null)
            {
                list2 = list2.next;
            }
        }
        //If there is carry while adding last 2 numbers then we can simply point current.next to the carry element
        if (carry > 0)
        {
            currentNode.next = new ListNode(carry);
        }

        //return dummy.next as dummy initially is pointing to 0
        return dummyNode.next;
    }
}