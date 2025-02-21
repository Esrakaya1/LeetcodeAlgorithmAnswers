public class Solution {
    // Iterative solution
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if(root == null) return result;
        // initialize a stack with the root node 
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root); 

        while(stack.Count > 0)
        {
            TreeNode node = stack.Pop(); // pop(take out) the node and visit it
            result.Add(node.val);
            if (node.right != null) stack.Push(node.right); // push its right child if any
            if (node.left != null) stack.Push(node.left); // push its left child if any 
        }
        return result;
    }
}
// time complexity: O(n), where n is the number of nodes in the tree. Each node is visited once.
// space complexity: O(h), where h is the height of the tree (due to the stack). In the worst case, the tree is linear and the height is O(n). In the best case, the tree is balanced and the height is O(logn).