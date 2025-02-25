public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if(root == null) return result;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count > 0) {
            TreeNode node = stack.Pop();
            result.Insert(0,node.val);
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }
        return result;
    }
}

// time complexity: O(n ^ 2), In the worst case, inserting at index 0 takes O(N) time per insertion. Since we do this for each node, the total cost becomes O(N²).
// space complexity: O(n) due to the stack. In the worst case, the tree is linear and the height is O(n). In the best case, the tree is balanced and the height is O(logn).