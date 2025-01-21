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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return BuildTree(nums, 0, nums.Length - 1);
    }

    private TreeNode BuildTree(int[] nums, int left, int right)
    {

        if (left > right)
        {
            return null;
        }

        // find the mid. element
        int mid = left + (right - left) / 2;

        // create the root node for this subtree
        TreeNode root = new TreeNode(nums[mid]);

        // recursively build the left and right subtrees
        root.left = BuildTree(nums, left, mid - 1);
        root.right = BuildTree(nums, mid + 1, right);

        return root;
    }
}

// time complexity : O(n) where n is the total number of nodes in the binary tree
// space complexity : O(h) where h is the height of the binary tree