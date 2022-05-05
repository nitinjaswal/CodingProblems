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
        public static void Main(String[] args)
        {
            char[] letters = { 'c', 'f', 'j' };
            char smallestCharacter = NextGreatestLetter(letters, 'a');
        }
        public static char NextGreatestLetter1(char[] letters, char target)
        {
            int i;
            for (i = 0; i <= letters.Length - 1; i++)
            {
                if (letters[i] > target)
                {
                    return letters[i];
                }
            }
            return letters[0];
        }

        public static char NextGreatestLetter(char[] letters, char target)
        {
            int low = 0;
            int high = letters.Length-1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (letters[mid] <= target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid-1;
                }
            }
            if (low == letters.Length)
            {
                return letters[0];
            }
            else
            {
                return letters[low];
            }
        }
    }
}








