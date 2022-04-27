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
        static Dictionary<int, int> map = new Dictionary<int, int>();
        public static void Main(String[] args)
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            // int index = FirstUniqChar("loveleetcode");
            double result = MyPowRec(2, -2);

        }
        //Recursive
        public static double MyPowRec(double x, int n)
        {
            int power = n;
            double result = 1;

            //Edge case if power is -ve
            if (power < 0)
            {
                x = 1 / x;
                power = -power;
            }

            if (n == 0)
            {
                return 1;
            }
            else if (power % 2 == 1)
            {
                result = MyPowRec(x, power - 1);
                return result * result;
            }
            else
            {
                return x * MyPowRec(x, power / 2);
            }


        }
        //Iterative
        public static double MyPow(double x, int n)
        {
            double power = n;
            double result = 1;

            //Edge case if power is -ve
            if (power < 0)
            {
                x = 1 / x;
                power = -power;
            }

            while (power > 0)
            {
                if (power % 2 == 1)
                {
                    power = power - 1;
                    result = result * x;
                }
                else //if power is even
                {
                    power = power / 2;
                    x = x * x;
                }
            }
            return result;
        }
    }

}








