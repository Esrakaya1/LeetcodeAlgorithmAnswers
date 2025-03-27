public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int result = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            int curr = columnTitle[i] - 'A' + 1;
            result = result * 26 + curr;
        }
        return result;
    }
}

// time complexity: O(N), where N is the length of columnTitle.
// space complexity: O(1) since we only use a few variables to store the result and the current value.