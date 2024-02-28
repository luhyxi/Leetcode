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
public class Solution {
public bool IsSameTree(TreeNode p, TreeNode q)
{
    // If both nodes are null, they are considered equal
    if (p == null && q == null) return true;

    // If one node is null and the other is not, they are not equal
    if (p == null || q == null) return false;

    // If the values of the nodes are not equal, they are not equal
    if (p.val != q.val) return false;

    // Check the equality of child nodes using recursion
    return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}