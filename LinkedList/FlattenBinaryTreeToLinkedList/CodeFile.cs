using System.Collections.Generic;

public class SolutionFlatten
{
    public void Flatten(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();

        if (root == null)
        {
            return;
        }
        TreeNode curr = root;
        stack.Push(curr);

        while (stack.Count > 0)
        {
            TreeNode currentNode = stack.Peek();
            stack.Pop();
            if (currentNode.right != null)
            {
                stack.Push(currentNode.right);
            }
            if (currentNode.left != null)
            {
                stack.Push(currentNode.left);
            }
            if (stack.Count > 0)
            {
                currentNode.right = stack.Peek();
            }
            currentNode.left = null;
        }
    }
}