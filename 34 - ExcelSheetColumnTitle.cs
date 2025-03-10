public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        if (columnNumber == 0) return "";
        columnNumber--;
        char c = (char)('A' + columnNumber % 26);
        return ConvertToTitle(columnNumber / 26) + c;
    }
}

// time complexity: O(log₍₂₆₎ N), where N is columnNumber.
// space complexity: O(logN) to keep the recursion stack. Recursive calls take up memory in the call stack. 
// The maximum depth of recursion is also O(log N).
//  If we ignore recursion stack space, the function only stores a few variables (char c, columnNumber), so its auxiliary space is O(1).