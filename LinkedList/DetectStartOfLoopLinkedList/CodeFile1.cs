
using System.Collections.Generic;
/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int x) {
*         val = x;
*         next = null;
*     }
* }
*/
public class SolutionDetectCycleHashSet
{
    public ListNode DetectCycle(ListNode head)
    {
        var hashTable = new HashSet<ListNode>();
        var elem = head;
        while (elem != null)
        {
            if (hashTable.Contains(elem))
            {
                return elem;
            }

            hashTable.Add(elem);
            elem = elem.next;
        }

        return null;
    }
}