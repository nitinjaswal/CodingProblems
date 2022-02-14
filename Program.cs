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


        public static void ReverseString(char[] s,int leftPointer, int rightPointer)
        {
            int i = 0;
            for (int j = s.Length - 1; i < j; j--)
            {
                var temp = s[j];
                s[j] = s[i];
                s[i] = temp;
                i++;
            }
        }

        private stat

    }

}








