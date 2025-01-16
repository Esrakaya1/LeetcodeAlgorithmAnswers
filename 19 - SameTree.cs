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
    public bool IsSameTree(TreeNode p, TreeNode q) {

        if(p == null && q== null)
        {
            return true;
        }
         if (p != null && q != null && p.val == q.val) {
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
        return false;
    }
}

// time complexity: O(n) n is the total number of nodes in the binary trees.
// space complexity: O(logn) or O(n) In the worst case, O(n) because of skewed tree.