public class Solution
{
    public IList<int> GetRow(int rowIndex)
    {
        List<int> result = new List<int>();

        result.Add(1);

        for (int i = 1; i <= rowIndex; i++)
        {
            // use the formula C(r, i) = C(r, i-1) * (r - i + 1) / i
            long currentElement = (long)result[i - 1] * (rowIndex - i + 1) / i;
            result.Add((int)currentElement);
        }
        return result;
    }
}
// time complexity: O(n) where n is the rowIndex
// space complexity: O(n) where n is the rowIndex Since no extra data structures are used (only the result list), the space complexity is: O(rowIndex)
// second solution
/*
public class Solution {
   public IList<int> GetRow(int rowIndex)
        {
            // base case 
            if (rowIndex == 0)
                return new List<int>() { 1 };

            if (rowIndex == 1)
                return new List<int>() { 1, 1 };


            var lastRow = GetRow(rowIndex - 1);

            // current row starts with 1
            List<int> res = new List<int>() { 1 };

            // current row should have 1+lastRow.count
            for (int i = 1; i < lastRow.Count; i++)
            {
                res.Add(lastRow[i - 1] + lastRow[i]);
            }

            // current row ends with 1
            res.Add(1);

            return res;
        }
}
*/

