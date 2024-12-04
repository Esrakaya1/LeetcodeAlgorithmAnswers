public class Solution
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {

            for (int j = i + 1; j < nums.Length; j++)
            {

                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return null;
    }
}