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
            triangle2(4, 0);
        }

        static void triangle1(int r, int c)
        {
            if (r == 0)
            {
                return;
            }
             if (c < r)
            {
                Console.Write("*");
                triangle1(r, c:c+1);
            }
            else
            {
                Console.WriteLine();
                triangle1(r:r-1, c:0);
            }
        }
        static void triangle2(int r, int c)
        {
            if (r == 0)
            {
                return;
            }
            if (c < r)
            {
                triangle2(r, c: c + 1);
                Console.Write("*");
            }
            else
            {
     
                triangle2(r: r - 1, c: 0);
                Console.WriteLine();
            }
        }
    }

}








