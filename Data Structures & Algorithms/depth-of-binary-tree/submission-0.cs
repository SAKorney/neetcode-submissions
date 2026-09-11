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
    public int MaxDepth(TreeNode root) {
        int MaxDepth(TreeNode root, int maxDepth) {
            if (root is null) return maxDepth;
            int depthL = MaxDepth(root.left, maxDepth+1);
            int depthR = MaxDepth(root.right, maxDepth+1);
            maxDepth = Math.Max(depthL,depthR);
            return maxDepth;
        }
        return MaxDepth(root, 0);    
    }
}
