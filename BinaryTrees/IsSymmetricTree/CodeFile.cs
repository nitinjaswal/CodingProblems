using System.Collections.Generic;

public class SolutionIsSymmetricIterative
{
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        Queue<TreeNode> leftQ = new Queue<TreeNode>();
        Queue<TreeNode> rightQ = new Queue<TreeNode>();
        leftQ.Enqueue(root);
        rightQ.Enqueue(root);
        while (leftQ.Count > 0)
        {
            var left = leftQ.Dequeue();
            var right = rightQ.Dequeue();

            if (left == null && right == null)
            {
                continue;
            }
            if (left == null || right == null)
            {
                return false;
            }
            else if (left.val != right.val)
            {
                return false;
            }

            leftQ.Enqueue(left.left);
            rightQ.Enqueue(right.right);

            leftQ.Enqueue(left.right);
            rightQ.Enqueue(right.left);
        }
        return true;
    }
}