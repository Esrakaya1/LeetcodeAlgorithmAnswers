public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0) return x;

        int low = 1, high = x, ans = 0;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (x / mid == mid) return mid;
            else if (x / mid < mid) high = mid - 1;
            else { low = mid + 1; ans = mid; }
        }
        return ans;
    }

    // Time Complexity: O(log(n)) binary search
    // Space Complexity: O(1)

    // 2. solution
    public int MySqrt(int x)
    {
        if (x < 2)
            return x;

        int left = 2;
        int right = x / 2;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            long num = (long)mid * mid;

            if (num > x)
            {
                right = mid - 1;
            }
            else if (num < x)
            {
                left = mid + 1;
            }
            else
                return mid;
        }

        return right;

    }
}