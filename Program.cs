using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenges.Queue.ShortestDistance;

namespace Challenges
{
    public class TreeNode
    {
        public int val;
        public TreeNode left, right;

        public TreeNode(int item)
        {
            val = item;
            left = right = null;
        }
    }
    class LinkedList
    {

        public static void Main(String[] args)
        {
            //string[] sentences = { "alice and bob love leetcode", "i think so too", "this is great thanks very much" };
            //string[] currentBig = new string[sentences.Length-1];
            //int newBig = 0;


            //for (int i = 0; i < sentences.Length; i++)
            //{
            //    currentBig = sentences[i].Split(" ");
            //    if (newBig < currentBig.Length)
            //    {
            //        newBig = currentBig.Length;
            //    }
            //}

            //Console.WriteLine(newBig);
            var result = IsPalindrome(-1);
        }

        static bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            return x == ReverseNumber(x);
        }


        static long ReverseNumber(int num)
        {
            int digits = (int)Math.Floor(Math.Log10(num) + 1);
            return helper(num, digits);
        }

        private static long helper(int n, int digits)
        {
            if (n % 10 == n)
            {
                return n;
            }
            int rem = n % 10;
            return rem * (long)Math.Pow(10, digits - 1) + helper(n / 10, digits - 1);
        }

    }

}








