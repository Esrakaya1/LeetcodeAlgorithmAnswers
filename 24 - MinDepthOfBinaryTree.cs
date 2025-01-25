public class Solution
{
    public int MinDepth(TreeNode root)
    {

        // First Solution (DFS -> Depth First Search)
        // Start from the root and recursively calculate the depth of the left and right subtrees.
        // The depth of a node is 1 + min(depth_of_left_subtree, depth_of_right_subtree). If a node has no left or right child, treat the depth of that child as infinite.

        /* if( root == null)
            return 0;
        int depthLeft = MinDepth(root.left);
        int depthRight = MinDepth(root.right);
        if (depthLeft == 0)
            return depthRight + 1;
        if (depthRight == 0)
            return depthLeft + 1;           
        return 1 + Math.Min(depthRight, depthLeft);
        */


        // Second(Optimal) Solution (BFS -> Breadth First Search)

        // Start at the root and perform a level-order traversal.
        // For each level, check if the node is a leaf. The first leaf node encountered will be the minimum depth node.
        // This approach ensures that the first leaf node we encounter is at the minimum depth.

        /*
        - Initialize a queue with the root node and its depth.
        - Traverse the tree level by level, adding children to the queue.
        - When a leaf node is encountered, return the current depth.
        */

        if (root == null) return 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var depth = 0;

        while (queue.Count != 0)
        {
            var size = queue.Count;

            for (var i = 0; i < size; i++)
            {
                var current = queue.Dequeue();

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
                if (current.left == null && current.right == null)
                {
                    return depth + 1;
                }
            }
            depth++;
        }
        return 0;
    }
}

// time complexity: O(n) where n is the number of nodes in the tree.
// space complexity: O(n) where n is the number of nodes in the tree. 