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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null) {
            return false;
        }
        bool final = false;
        if(root.left == null && root.right == null) {
            if(root.val == targetSum) {
                return true;
            }
            else {
                return false;
            }
        }
        else { //If the current node is not a leaf, the function checks its left and right children.
            if(root.left != null) {
                final = final || HasPathSum(root.left, targetSum - root.val);
            }
            if(root.right != null) {
                final = final || HasPathSum(root.right, targetSum - root.val);
            }
        }
        return final;
    }
}

// Time Complexity: O(n) the function visits every node once in the binary tree. Where n is the nuımber of nodes in the tree.
// Space Complexity: O(h) where h is the height of the tree. The best case(balanced tree) is O(logn) and the worst case is O(n) (skewed tree).