public class Solution
{
    public bool IsPalindrome(string s)
    {
        for (int i = 0, j = s.Length - 1; j > i;)
        {
            if (!char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }

            if (char.ToLower(s[i++]) != char.ToLower(s[j--]))
            {
                return false;
            }
        }
        return true;
    }
}
// time complexity: O(n) where n is the length of the string
// space complexity: O(1) there is no extra space used.