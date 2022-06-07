
using System.Collections.Generic;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*         this.val = val;
*         this.left = left;
*         this.right = right;
*     }
* }
*/
public class SolutionZigzagLevelOrder
{
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var levelOrder = new List<IList<int>>();
        int traversalDirection = 0;//left to right

        if (root == null)
        {
            return levelOrder;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var list = new List<int>();
        list.Add(root.val);
        levelOrder.Add(list);
        while (queue.Count > 0)
        {
            list = new List<int>();
            var level = queue.Count;

            for (int i = 0; i < level; i++)
            {
                var currentNode = queue.Dequeue();

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                    list.Add(currentNode.left.val);
                }
                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                    list.Add(currentNode.right.val);
                }
            }

            if (list.Count > 0)
            {
                if (traversalDirection == 0)
                {
                    list.Reverse();
                    levelOrder.Add(list);
                    traversalDirection = 1;
                }
                else
                {

                    levelOrder.Add(list);
                    traversalDirection = 0;
                }

            }
        }

        return levelOrder;
    }
}