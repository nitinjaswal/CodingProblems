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

            int length = GuessNumber(8);
        }

        public static int GuessNumber(int n)
        {
            int low = 0;
            int high = n;
            int mid = 0;
            while (low <= high)
            {
                mid = low + (high - low) / 2;
                int guess = guess(mid);
                if (guess == 0)
                {
                    return mid;
                }
                else if (guess == 1)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return 0;
        }

        public class Solution : GuessGame
        {
            public int GuessNumber(int n)
            {
                int num = n, diff = (int)(num / 2);
                do
                {
                    if (guess(num) == -1)
                        num = num - diff;
                    else if (guess(num) == 1)
                        num = num + diff;

                    diff = (int)(diff / 2);
                    if (diff == 0) diff = 1;

                } while (guess(num) != 0);
                return num;
            }
        }
    }

}








