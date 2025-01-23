public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1) return strs[0];  // It's gonna be just one prefix so we return it.

        string prefix = "";  // store the common prefix
        int index = 0; // index of each character

        while (index != strs[0].Length)
        {
            char compare = strs[0][index]; // compare is the standard character from the first string that all others must match
            for (int i = 1; i < strs.Length; i++)
            {
                if (index == strs[i].Length || strs[i][index] != compare)
                    return prefix;
            }
            prefix += compare;
            index++;
        }
        return prefix;
    }
}