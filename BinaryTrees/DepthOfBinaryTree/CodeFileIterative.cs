using System.Collections.Generic;

public class IterativeMaxDepth
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int treeLevel = 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var currentNode = root;
        while (queue.Count > 0)
        {
            treeLevel++;
            var level = queue.Count;
            for (int i = 0; i < level; i++)
            {
                currentNode = queue.Dequeue();
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