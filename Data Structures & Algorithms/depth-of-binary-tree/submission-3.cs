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
        if (root is null) return 0;
        Stack<(TreeNode, int)> nodesInfo = new(100);
        nodesInfo.Push((root, 1));
        int ans = 0;
        while (nodesInfo.Count > 0) {
            var curr = nodesInfo.Pop();
            var node = curr.Item1;
            var depth = curr.Item2;            
            ans = Math.Max(ans, depth);
            if (node.left is not null) nodesInfo.Push((node.left, depth+1));
            if (node.right is not null) nodesInfo.Push((node.right, depth+1));
        }
        return ans;
    }
}
