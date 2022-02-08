using System.Collections.Generic;

public class LevelOrderTraversal
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var levelOrder = new List<IList<int>>();


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
                levelOrder.Add(list);
            }
        }

        return levelOrder;
    }
}