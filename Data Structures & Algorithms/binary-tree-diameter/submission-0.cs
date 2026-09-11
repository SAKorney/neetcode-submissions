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
    public int DiameterOfBinaryTree(TreeNode root) {
        if (root is null) return 0;
        int d = 0;
        int Calculate(TreeNode root) {
            if (root is null) return 0;
            int l = Calculate(root.left);
            int r = Calculate(root.right);
            d = Math.Max(d, l+r);
            return 1 + Math.Max(l, r);
        }
        Calculate(root);
        return d;
    }
}
