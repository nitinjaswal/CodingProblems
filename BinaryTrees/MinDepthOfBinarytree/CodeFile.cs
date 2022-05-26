using System.Collections.Generic;
using System.Linq;

public class SolutionMinDepthOfBinaryTree
{
    public int MinDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }
        int minDepth = 1;
        int currentDepth = 1;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int size = queue.Count();
            //looping all the item level order(which are present in queue)
            for (int i = 0; i < size; i++)
            {
                var item = queue.Dequeue();
                //as soon as leaf node is found we return the depth count as there is no need to traverse whole tree
                if (item.left == null && item.right == null)
                {
                    return minDepth;
                }
                if (item.left != null)
                {
                    currentDepth++;
                    queue.Enqueue(item.left);

                }
                if (item.right != null)
                {

                    queue.Enqueue(item.right);
                }
            }
            minDepth++;
        }
        return minDepth;
    }
}
