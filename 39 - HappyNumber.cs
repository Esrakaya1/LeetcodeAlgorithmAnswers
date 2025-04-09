public class Solution
{
    public bool IsHappy(int n)
    {
        if (n == 1 || n == 7) return true;
        else if (n < 10) return false;
        else
        {
            int sum = 0;
            while (n > 0)
            {
                int temp = n % 10;
                sum += temp * temp;
                n = n / 10;
            }
            return IsHappy(sum);
        }
    }
}
// (recursion)

// time complexity: O(log n) because the number of digits in n is log n, and we are doing a constant amount of work for each digit. The maximum number of iterations is 7, so the overall time complexity is O(7 * log n) = O(log n).
// space complexity: O(1) because we are using a constant amount of space for the variables sum and temp. The recursion stack will also use O(log n) space, but since we are not storing any additional data structures, the overall space complexity is O(1).


// 2. solution (two ponters)
public class Solution
{
    public bool IsHappy(int n)
    {
        int slow = n;
        int fast = n;

        do
        {
            slow = square(slow);
            fast = square(square(fast));
        }
        while (slow != fast);

        return slow == 1;

    }

    public int square(int num)
    {
        int ans = 0;

        while (num > 0)
        {
            int remainder = num % 10;
            ans += remainder * remainder;
            num /= 10;
        }
        return ans;
    }
}

// time complexity: O(log n) because the number of digits in n is log n, and we are doing a constant amount of work for each digit. The maximum number of iterations is 7, so the overall time complexity is O(7 * log n) = O(log n).
// space complexity: O(1) because we are using a constant amount of space for the variables slow, fast, and ans. The recursion stack will also use O(log n) space, but since we are not storing any additional data structures, the overall space complexity is O(1).

