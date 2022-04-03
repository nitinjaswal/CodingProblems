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
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            int maxProfit = MaxProfit(arr);

        }

        //brute force approach:O(n^2)
        public static int MaxProfit1(int[] prices)
        {
            //using 2 loops and checking max profit 
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j <= prices.Length - 1; j++)
                {
                    int currentProfit = prices[j] - prices[i];
                    if (currentProfit > maxProfit)
                    {
                        maxProfit = currentProfit;
                    }
                }
            }
            return maxProfit;
        }

        //Optimal approach : in O(n)
        public static int MaxProfit(int[] prices)
        {
            int min = prices[0];
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                }
                else if (maxProfit < prices[i] - min)
                {
                    maxProfit  = prices[i]- min;
                }
            }
            return maxProfit;
        }


    }

}








