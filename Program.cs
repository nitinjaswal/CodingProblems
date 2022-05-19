using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        static ListNode listNode = null;
        public static void Main(String[] args)
        {
            string s = "a";
            int length = LengthOfLastWord(s);
            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);
        }
        public static int LengthOfLastWord(string s)
        {
            char[] charArray = s.ToCharArray();
            int length = 0;
            for (int i = charArray.Length - 1; i > 0; i--)
            {
                if (charArray[i] != ' ')
                {
                    length++;
                }
                else
                {
                    if (length > 0)
                    {
                        return length;
                    }
                }
            }
            return length;
            //var list = s.Split();
            //var result = new List<string>();
            //foreach (var item in list)
            //{
            //    if (item.Length > 0)
            //    {
            //        result.Add(item);
            //    }
            //}
            //return result.Last().Length;
        }
    }
}








