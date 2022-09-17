
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
public class SolutionAverageOfLevels
{
    public IList<double> AverageOfLevels(TreeNode root)
    {
        if (root == null)
        {
            return null;
        }

        List<double> result = new List<double>();
        double average = 0.0;
        double sum = 0.0;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int qsize = queue.Count;
            for (int i = 0; i < qsize; i++)
            {
                var node = queue.Dequeue();
                sum = sum + node.val;
                average = sum / qsize;
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            result.Add(average);
            //reset sum to 0
            sum = 0;
        }
        return result;
    }
}