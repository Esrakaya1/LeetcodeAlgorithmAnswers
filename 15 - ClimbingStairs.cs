public class Solution
{
    public int ClimbStairs(int n)
    {
        if (n <= 3) return n;

        int prev = 1, curr = 1;
        for (int i = 2; i <= n; i++)
        {
            curr = prev + curr;
            prev = curr - prev;
        }
        return curr;
    }
}

// time complexity => O(n): The loop runs n-1 times, so the time grows linearly with n

// space complexity => O(1): Only prev and curr variables are used,  no extra space for arrays or recursion stacks.