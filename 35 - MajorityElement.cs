public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int major = nums[0], count = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (count == 0)
            {
                count++;
                major = nums[i];
            }
            else if (major == nums[i])
            {
                count++;
            }
            else count--;
        }
        return major;
    }
}
// Boyer-Moore Voting Algorithm
// Time complexity: O(n) We only go through the array once, from left to right. There are no nested loops or extra operations that depend on n.
// Space complexity: O(1) We only use a constant amount of extra space. We don’t use extra data structures like arrays, hash tables, or recursion.