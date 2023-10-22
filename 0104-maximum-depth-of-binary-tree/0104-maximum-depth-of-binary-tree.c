int maxDepth(struct TreeNode* root) {
    if (root == NULL) {
        return 0; // Base case: if the root is NULL, the depth is 0.
    }

    int leftDepth = maxDepth(root->left);  // Calculate the depth of the left subtree.
    int rightDepth = maxDepth(root->right); // Calculate the depth of the right subtree.

    // Return the maximum depth between the left and right subtrees, plus 1 for the current node.
    return (leftDepth > rightDepth) ? (leftDepth + 1) : (rightDepth + 1);
}