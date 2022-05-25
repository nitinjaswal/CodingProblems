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

            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);

            int numberToFind = 6;
            int[,] array = new int[3, 3]
            {
                {1, 2, 3 },
                {4,5,6 },
                {7,8,9 }
            };
            int[] arr = new int[] { 1, 4, 45, 6, 10, 19 };

            string str = "abcdefg";//"s'teL ekat edoCteeL tsetnoc"
            string s = ReverseStr(str,2);

        }

        public static string ReverseStr(string s, int k)
        {

        }
        public static string ReverseWords(string s)
        {

            StringBuilder sb = new StringBuilder();
            var words = s.Split(' ');

            for (int i = 0; i <= words.Length - 1; i++)
            {
                if (words[i] != "")
                {
                    string reversedString = ReverseString(words[i].ToCharArray());
                    sb.Append(reversedString);
                    sb.Append(' ');
                }
            }

            return sb.ToString().TrimEnd();
        }
        public static string ReverseString(char[] s)
        {
            int i = 0;
            for (int j = s.Length - 1; i < j; j--)
            {
                var temp = s[j];
                s[j] = s[i];
                s[i] = temp;
                i++;
            }
            string str = new string(s);
            return str.ToString();
        }
    }

}









