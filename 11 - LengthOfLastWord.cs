public class Solution {
    public int LengthOfLastWord(string s) {
        int n = s.Length;
        int t = 0;

        for(int i = n - 1; i >= 0; i--)
        {
            if(s[i] == ' ')
            {
              if(t != 0)
              {
                return t;
              }
            }
            else 
            {
                t++;
            }
        }
        return t;
    }
}