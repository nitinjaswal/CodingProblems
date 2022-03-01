public class SolutionSearchBSTRecursive
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        //Base case
        if (root == null || root.val == val)
        {
            return root;
        }
        else
        {
            if (val > root.val)
            {
                root = root.right;
            }
            else if (val < root.val)
            {
                root = root.left;
            }
            return SearchBST(root, val);
        }
    }
}