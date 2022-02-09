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

            //tree.root.right.right = new Node(7);
            //tree.root.right.left = new Node(6);
            //tree.root.right.left = new Node(7);
            var res = LevelOrder(tree.root);
        }

        public static int LevelOrder(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            int treeLevel = 0;

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            var currentNode = root; 
            while (queue.Count > 0)
            {
                treeLevel++;           
                var level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    currentNode  = queue.Dequeue();
                    if (currentNode.left != null)
                    {
                        queue.Enqueue(currentNode.left);
                    }
                    if (currentNode.right != null)
                    {
                        queue.Enqueue(currentNode.right);
                    }
                }
            }

            return treeLevel;
        }
    }

}








