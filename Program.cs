﻿using System;
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
            int length = FirstBadVersion(8);
        }

        public int FirstBadVersion(int n)
        {
            int low = 0;
            int high = n;
            int mid = 0;
            while (low <= high)
            {
                mid = low + (high - low) / 2;

                if (IsBadVersion(mid))
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}








