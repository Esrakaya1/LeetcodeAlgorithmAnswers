public class Solution {
    public int SingleNumber(int[] nums) {
        int result = nums[0];
        if(nums.Length == 1)
        {
            return nums[0];
        }
        for(int i=1; i<nums.Length; i++)
        {
            result = result^nums[i];
        }
        return result;
    }
}
// Second solution 
/*
public class Solution
{
    public int SingleNumber(int[] nums)
	{
        return nums.Aggregate((x, i) => x ^ i);    
    }
}
*/

// Bitwise XOR operation used
// Time complexity: O(n) where n is the number of elements in the array
// Space complexity: O(1) as no extra space is used