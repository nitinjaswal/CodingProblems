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

            PreOrderBinaryTree tree = new PreOrderBinaryTree();
            tree.root = new Node(1);
            tree.root.left = new Node(2);
            tree.root.right = new Node(3);
            tree.root.left.left = new Node(4);
            tree.root.left.right = new Node(5);
            tree.root.left.right.left = new Node(6);
            tree.root.left.right.right = new Node(7);
            //tree.root.right.left = new Node(7);
            var res = PreorderTraversal(tree.root);
        }

        public static IList<int> PreorderTraversal(Node root)
        {
            Stack<Node> stack = new Stack<Node>();
            List<int> inOrder = new List<int>();
            if (root == null) return inOrder;
            //   stack.Push(root);//Insert root node in stack
            var node = root;
            while (node!=null || stack.Count>0)
            {
                //iterate each left node and put it into the stack
                while (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }

                node = stack.Pop();
                inOrder.Add(node.data);
                node = node.right;
            }
            return inOrder;
        }
    }

}








