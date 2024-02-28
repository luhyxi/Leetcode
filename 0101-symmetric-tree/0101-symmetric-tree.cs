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

    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) 
            return true;
        if (root.right is null && root.left is not null)
            return false;
        if (root.right is not null && root.left is  null)
            return false;

        return IsSymmetricHelper(root.left, root.right);
    }

    private bool IsSymmetricHelper(TreeNode left, TreeNode right)
    {
        if (left == null && right == null) // Ambos null, simétricos
            return true;
        if (left == null || right == null) // Diferentes, não simétricos
            return false;

        return left.val == right.val &&
               IsSymmetricHelper(left.left, right.right) &&
               IsSymmetricHelper(left.right, right.left);
    }

}