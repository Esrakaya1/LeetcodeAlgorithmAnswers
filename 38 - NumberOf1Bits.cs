public class Solution
{
    public int HammingWeight(int n)
    {
        var count = 0;

        while (n > 0)
        {
            count += (n & 1);
            n >>= 1;
        }

        return count;
    }
}

// The Hamming weight (or population count) of a number is the number of 1 bits in its binary representation.

// Time complexity: O(log n) because we are dividing the number by 2 in each iteration, which is equivalent to shifting the bits to the right.

// Space complexity: O(1) because we are using a constant amount of space to store the count variable and n.