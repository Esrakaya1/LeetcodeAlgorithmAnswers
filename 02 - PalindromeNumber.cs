public class Solution
{
    // without converting the integer to a string
    public bool IsPalindrome(int x)
    {

        if (x < 0) return false;

        int temp = x;
        int reverse = 0;

        while (temp != 0)
        {

            int digit = temp % 10;  // the last digit of the temp
            reverse = reverse * 10 + digit;  // add digit to reverse
            temp /= 10;  // remove the last digit from temp. If temp=121, after temp /= 10, it becomes 12.
        }
        if (reverse == x)
            return true;

        return false;



        // 2. solution
        // var reverseString = x.ToString().Reverse();
        // if (string.Concat(reverseString) != x.ToString())
        //     return false;
        // return true;
    }
}