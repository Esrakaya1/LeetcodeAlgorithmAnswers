public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, int> charIndexS = new Dictionary<char, int>();
        Dictionary<char, int> charIndexT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!charIndexS.ContainsKey(s[i]))
            {
                charIndexS[s[i]] = i;
            }

            if (!charIndexT.ContainsKey(t[i]))
            {
                charIndexT[t[i]] = i;
            }

            if (charIndexS[s[i]] != charIndexT[t[i]])
            {
                return false;
            }
        }
        return true;
    }
}
// time complexity: O(n), where n is the length of the string s or t
// space complexity: O(n), We’re using two dictionaries: charIndexS and charIndexT. That means we store n different characters in each dictionary.