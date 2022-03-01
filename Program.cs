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
        public Node root;
        public static void Main(String[] args)
        {
            TreeNode root = new TreeNode(1);

            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);

        }

        public TreeNode SearchBST(TreeNode root, int val)
        {
            //Base case
            if (root == null && root.val == val)
            {
                return root;
            }

            if (val > root.val)
            {
                root = root.right;
                return SearchBST(root, val);
            }
            else if (val < root.val)
            {
                root = root.left;
                return SearchBST(root, val);
            }
        }

    }

}








