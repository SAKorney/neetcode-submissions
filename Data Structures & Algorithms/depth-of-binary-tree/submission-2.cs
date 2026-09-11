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
        Stack<(TreeNode, int)> nodesInfo = new();
        nodesInfo.Push((root, 1));
        int ans = 0;
        while (nodesInfo.Count > 0) {
            var curr = nodesInfo.Pop();
            var node = curr.Item1;
            var depth = curr.Item2;

            if (node != null) {
                ans = Math.Max(ans, depth);
                nodesInfo.Push((node.left, depth+1));
                nodesInfo.Push((node.right, depth+1));
            }

        }
        return ans;
    }
}
