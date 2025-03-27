public class Solution
{
    public uint reverseBits(uint n)
    {
        uint reversed = 0;
        for (int i = 0; i < 32; i++)
        {
            reversed = reversed << 1;
            if (n % 2 == 1)
                reversed++;
            n = n >> 1;
        }
        return reversed;
    }
}

// time complexity: O(1). We perform a constant number of operations.
// space complexity: We don't use any extra data structures—only a few integers. Thus, the space complexity is O(1).