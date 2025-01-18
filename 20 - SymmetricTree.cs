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
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null)
        {
            return true;
        }
        return isMirrored(root.left, root.right);
    }
    private bool isMirrored(TreeNode node1, TreeNode node2) // helper method and recursive function
    {
        if (node1 == null && node2 == null)
        {
            return true;
        }
        if (node1 == null || node2 == null)
        {
            return false;
        }
        return node1.val == node2.val && isMirrored(node1.left, node2.right) && isMirrored(node1.right, node2.left);
    }

    /*
    public bool IsSymmetric(TreeNode root) {
        return AreSymmetric(root.left, root.right);
    }
    private bool AreSymmetric(TreeNode left, TreeNode right) {
        if (left is null) return right is null;
        if (right is null) return left is null;
        if (left.val != right.val) return false;
        return AreSymmetric(left.left, right.right) && AreSymmetric(left.right, right.left);
    }
    */
}

// time complexity: O(n) where n is the number of nodes in the binary tree. We need to visit each node once to check if the tree is symmetric.
// space complexity: O(h) where h is the height of the tree. This is the space required for the recursive call stack. In the worst case, the height of the tree could be O(n) for a skewed tree, but on average, it's O(log n) for a balanced binary tree.