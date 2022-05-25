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
            var list = AddBinary("11", "1");
            string str = "the blue";
            reverseWords(str.ToCharArray());

        }

        public static string AddBinary(string a, string b)
        {
            int a1 = Convert.ToInt32(a);
            string binary = Convert.ToString(a1, 2);
            return binary;
        }

        public static void reverseWords(char[] str)
        {
            // reverse the whole input 
            Reverse(str, 0, str.Length - 1);
            int start = 0;

            //Reverse each individual word
            for (int i = 0; i <= str.Length - 1; i++)
            {
                //when whitespace is encountered, means we have found one string(and pass its indices to reverse)
                if (str[i] == ' ')
                {
                    Reverse(str, start, i - 1);
                    start = i + 1;
                }
                // if i reaches to last word in string
                if (i == str.Length - 1)
                {
                    Reverse(str, start, i);
                }
            }
        }

        private static void Reverse(char[] res, int start, int end)
        {
            while (start < end)
            {
                char temp = res[start];
                res[start] = res[end];
                res[end] = temp;
                start++;
                end--;
            }
        }

    }

}









