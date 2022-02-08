using System.Collections.Generic;

public class IterativePostorderTraversal
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        List<int> postOrder = new List<int>();
        if (root == null) return postOrder;
        //   stack.Push(root);//Insert root node in stack
        var currentNode = root;
        TreeNode lastNode = null;

        while (currentNode != null || stack.Count > 0)
        {
            //iterate each left node and put it into the stack
            if (currentNode != null)
            {
                stack.Push(currentNode);
                currentNode = currentNode.left;
            }
            else
            {
                currentNode = stack.Peek();
                if (currentNode.right == null || currentNode.right == lastNode)
                {
                    postOrder.Add(currentNode.val);
                    stack.Pop();
                    lastNode = currentNode;
                    currentNode = null;
                }
                else
                {
                    currentNode = currentNode.right;
                }
            }

        }
        return postOrder;
    }
}