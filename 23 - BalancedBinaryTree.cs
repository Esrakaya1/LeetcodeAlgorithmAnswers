public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return CheckBalance(root).isBalanced;
    }
    private (bool isBalanced, int height) CheckBalance(TreeNode root)
    {
        if (root == null)
        {
            return (true, 0); // A null tree is balanced with height 0
        }

        // Check left and right subtrees
        var left = CheckBalance(root.left);
        var right = CheckBalance(root.right);

        // Check if the current node is balanced
        bool isBalanced = left.isBalanced && right.isBalanced && Math.Abs(left.height - right.height) <= 1;

        // Calculate the height of the current node
        int height = Math.Max(left.height, right.height) + 1;

        return (isBalanced, height);
    }
}

// time complexity: O(n) Each node is visited once, and its height and balance status are calculated in constant time.
// space complexity: Recursive stack uses up to O(h), where h is the height of the tree. In the worst case, the tree is linear, so the space complexity is O(n). In the best case, the tree is balanced, so the space complexity is O(log n).