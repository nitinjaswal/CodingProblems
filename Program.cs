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
            string s = "xywrrmp";

            string t = "xywrrmu#p";
            bool length = BackspaceCompare(s, t);
            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);
        }
        public static bool BackspaceCompare(string s, string t)
        {
            return BuildString(s).Equals(BuildString(t));
        }
        public static string BuildString(string s)
        {
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                if (s[i].ToString() == "#")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(s[i].ToString());
                }
            }
            StringBuilder sb1 = new StringBuilder();
            while (stack.Count > 0)
            {
                sb1.Append(stack.Peek());
                stack.Pop();
            }
            return sb1.ToString();
        }
    }
}








