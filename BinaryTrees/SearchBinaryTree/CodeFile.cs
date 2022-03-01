public class SolutionSearchBST
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        var currentNode = root;
        while (currentNode != null)
        {
            if (currentNode.val == val)
            {
                return currentNode;
            }
            else if (val > currentNode.val)
            {
                currentNode = currentNode.right;
            }
            else if (val < currentNode.val)
            {
                currentNode = currentNode.left;
            }
        }
        return currentNode;
    }
}