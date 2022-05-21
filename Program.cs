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
            int[] nums = { 7, 1, 5, 3, 6, 4 };
            int pivot = MaxProfit(nums);
            listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            //listNode.next.next.next.next.next = new ListNode(4);
            //listNode.next.next.next.next.next.next = new ListNode(5);
            //var list = ReverseBetween(listNode, 2, 4);
        }
        public static  int MaxProfit(int[] prices)
        {

            int maxProfit = 0;
            int left = 0;
            int right = 1;
            while (right <= prices.Length - 1)
            {
                if (prices[left] < prices[right])
                {
                    int profit = prices[right] - prices[left];
                    if(profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
                else
                {
                    left= right;
                }
                right++;
            }
            return maxProfit;

        }
        public static int DominantIndex(int[] nums)
        {
            int largestNum = 0;
            int maxIndex = 0;
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] > largestNum)
                {
                    largestNum = nums[i];
                    maxIndex = i;
                }
            }
            for (int i = 0; i <= nums.Length - 1; i++)
            {
                if (nums[i] != largestNum && nums[i] * 2 > largestNum)
                {
                    return -1;
                }
                else
                {
                    continue;
                }
            }
            return maxIndex;

        }
    }
}








