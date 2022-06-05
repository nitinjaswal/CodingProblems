
using System.Collections.Generic;
/**
* Definition for a binary tree node.
* public class TreeNode {
*     public int val;
*     public TreeNode left;
*     public TreeNode right;
*     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
*         this.val = val;
*         this.left = left;
*         this.right = right;
*     }
* }
*/
public class SolutionIsSameTreeIterative
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;

        if (q == null || p == null) return false;
        if (p.val != q.val)
        {
            return false;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(p);
        queue.Enqueue(q);
        while (queue.Count > 0)
        {
            var itemP = queue.Peek();
            queue.Dequeue();
            var itemQ = queue.Peek();
            queue.Dequeue();
            if (itemP == null && itemQ == null)
            {
                continue;
            }
            if (itemP != null && itemQ == null)
            {
                return false;
            }
            if (itemP == null && itemQ != null)
            {
                return false;
            }
            if (itemP.val != itemQ.val)
            {
                return false;
            }
            else
            {
                queue.Enqueue(itemP.left);
                queue.Enqueue(itemQ.left);
                queue.Enqueue(itemP.right);
                queue.Enqueue(itemQ.right);
            }
        }

        return true;
    }
}