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
    public TreeNode InvertTree(TreeNode root) {
        if (root is null) return null;
        Stack<TreeNode> stack = new();
        stack.Push(root);
        while (stack.Count > 0) {
            var node = stack.Pop();
            var tmp = node.left;
            node.left = node.right;
            node.right = tmp;
            if (node.left is not null) stack.Push(node.left);
            if (node.right is not null) stack.Push(node.right);
        }
        return root;
    }
}
