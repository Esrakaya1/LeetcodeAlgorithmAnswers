public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>(nums.Length);

        for (var i = 0; i < nums.Length; i++)
        {
            if (!set.Add(nums[i])) return true;
        }

        return false;
    }
}

// Time complexity: O(n), where n is the number of elements in the array.
// Space complexity: O(n), where n is the number of unique elements in the array.
// The HashSet is used to store unique elements, and the Add method checks for duplicates.