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
public class Solution
{
    public int CountNodes(TreeNode root)
    {
        if (root == null)
            return 0;

        TreeNode left = root, right = root;
        int height = 0;

        while (right != null)
        {
            left = left.left;
            right = right.right;
            height++;
        }

        if (left == null)
            return (1 << height) - 1;

        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}
// Time Complexity: O(log(n)^2) the worst case. 
// Space Complexity: O(log(n)) the worst case. No extra data structures, no HashSets, just elegant recursion.