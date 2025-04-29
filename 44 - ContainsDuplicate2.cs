public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (numToIndex.ContainsKey(nums[i])
            && (i - numToIndex[nums[i]] <= k))
            {
                return true;
            }
            numToIndex[nums[i]] = i;
        }
        return false;
    }
}

// time complexity: That for loop goes through every element in nums once → that’s O(n) n = number of elements in the array
// space complexity: O(n) because we are using a dictionary to store the indices of the elements in nums. In the worst case, we would have to store all n elements in the dictionary.