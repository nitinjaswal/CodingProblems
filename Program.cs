using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
        static List<List<int>> output = new List<List<int>>();
        public static void Main(String[] args)
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int index = FirstUniqChar("loveleetcode");

        }

        public static int FirstUniqChar(string s)
        {
            var charArr = s.ToCharArray();
            Dictionary<char, int> set = new Dictionary<char, int>();

            //create hashtable and maintain count of each character
            for (int i = 0; i <= charArr.Length - 1; i++)
            {
                if (!set.ContainsKey(charArr[i]))
                {
                    set.Add(charArr[i], 1);
                }
                else
                {
                    //if element exist more than once, then update count
                    int old = (int)set[charArr[i]];
                    set[charArr[i]] = old + 1;
                }
            }

           
            for (int i = 0; i <= charArr.Length - 1; i++)
            {
                if (set[charArr[i]].Equals(1))
                {
                    return i;
                }
            }

            return -1;

        }

    }

}








