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
    public bool IsUnivalTree(TreeNode root)
    {
        if (root == null) return true;
        if (root.left is not null && root.left.val != root.val) return false;
        if (root.right is not null && root.right.val != root.val) return false;
        return IsUnivalTree(root.right) && IsUnivalTree(root.left);

    }
}