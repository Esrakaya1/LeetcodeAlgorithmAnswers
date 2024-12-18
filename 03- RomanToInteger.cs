public class Solution
{
    public int RomanToInt(string s)
    {
        int currVal = 0;
        int prevVal = 0;
        int res = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            switch (s[i])
            {
                case 'I':
                    currVal = 1;
                    break;
                case 'V':
                    currVal = 5;
                    break;
                case 'X':
                    currVal = 10;
                    break;
                case 'L':
                    currVal = 50;
                    break;
                case 'C':
                    currVal = 100;
                    break;
                case 'D':
                    currVal = 500;
                    break;
                case 'M':
                    currVal = 1000;
                    break;
            }
            if (currVal < prevVal)
            {
                res -= currVal;
            }
            else
            {
                res += currVal;
            }
            prevVal = currVal;
        }
        return res;

        // 2. solution
        //     var map = new Dictionary<char, int>();
        //     map.Add('I', 1);
        //     map.Add('V', 5);
        //     map.Add('X', 10);
        //     map.Add('L', 50);
        //     map.Add('C', 100);
        //     map.Add('D', 500);
        //     map.Add('M', 1000);

        //     int sum = 0;
        //     int last = 0;

        //     for(int i = s.Length - 1; i>=0; i--)
        //     {
        //         int current = map[s[i]];

        //         if(current < last)
        //         {
        //             sum -= current;
        //         }
        //         else 
        //         {
        //             sum += current;
        //         }
        //         last = current;
        //     }
        //     return sum;

    }
}