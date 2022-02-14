using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Challenges.Queue.ShortestDistance;

namespace Challenges
{
    public class Node
    {
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }
    class PreOrderBinaryTree
    {
        public Node root;
        public static void Main(String[] args)
        {
            //char[][] input = new char[4][];
            //input[0] = new char[5] { '1', '1', '0', '0', '0' };
            //input[1] = new char[5] { '1', '1', '0', '0', '0' };
            //input[2] = new char[5] { '0', '0', '1', '0', '0' };
            //input[3] = new char[5] { '0', '0', '0', '1', '1' };
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            ReverseString(s);

        }


        public static void ReverseString(char[] s)
        {
            ReverseHelper(s, 0, s.Length - 1);
        }

        private static void ReverseHelper(char[] s, int leftPointer, int rightPointer)
        {
            if (leftPointer >= rightPointer)
            {
                return;
            }
            var temp = s[rightPointer];
            s[rightPointer] = s[leftPointer];
            s[leftPointer] = temp;
            leftPointer++;
            rightPointer--;
            ReverseHelper(s, leftPointer, rightPointer);
        }

    }

}








