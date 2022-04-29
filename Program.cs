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
        static Dictionary<int, int> map = new Dictionary<int, int>();
        public static void Main(String[] args)
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            // int index = FirstUniqChar("loveleetcode");

            int length = LengthOfLongestSubstring("abcabcbb");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;

            if (s == "")
            {
                return 0;
            }
            for (int i = 0; i <= s.Length-1; i++)
            {
                string subString = "";
                for (int j = i; j <= s.Length-1 ; j++)
                {
                    if (!subString.Contains(s[j]))
                    {
                        subString = subString + s[j];
                        maxLength = Math.Max(maxLength, subString.Length);
                    }
                    else
                    {
                        break;
                    }
                }               

            }
            return maxLength;
        }

    }

}








