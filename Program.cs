using System;

namespace Challenges
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
    class LinkedList
    {
        public static void Main(String[] args)
        {

            SubSets("abc", "");

        }

        private static void SubSets(string originalString, string newString)
        {
            if (string.IsNullOrEmpty(originalString))
            {
                Console.WriteLine(newString);
                return;
            }

            string ch = originalString.Substring(0, 1);

            SubSets(originalString.Substring(1), newString + ch);
            SubSets(originalString.Substring(1), newString);
        }
    }

}








