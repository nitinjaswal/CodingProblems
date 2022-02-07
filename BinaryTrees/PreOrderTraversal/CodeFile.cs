
using System.Collections.Generic;

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
public class IterativePreorderTraversal
{
    public IList<int> PreorderTraversal(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<int> preOrder = new List<int>();
        if (root == null) return preOrder;
        stack.Push(root);//Insert root node in stack
        while (stack.Count > 0)
        {
            var node = stack.Pop();

            //Pop the node from the stack and print it
            preOrder.Add(node.val);

            //First we push right node as we want to process left node first(LIFO)
            if (node.right != null)
            {
                stack.Push(node.right);
            }
            if (node.left != null)
            {
                stack.Push(node.left);
            }
        }
        return preOrder;
    }
}