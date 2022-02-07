using System.Collections.Generic;

public class IterativeInorderTraversal
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<int> inOrder = new List<int>();
        if (root == null) return inOrder;
        //   stack.Push(root);//Insert root node in stack
        var node = root;
        while (node != null || stack.Count > 0)
        {
            //iterate each left node and put it into the stack
            while (node != null)
            {
                stack.Push(node);
                node = node.left;
            }

            node = stack.Pop();
            inOrder.Add(node.val);
            node = node.right;
        }
        return inOrder;
    }
}