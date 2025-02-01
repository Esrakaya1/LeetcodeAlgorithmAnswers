public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> triangle = new List<IList<int>>();
        if (numRows == 0) return triangle;

        triangle.Add(new List<int>() { 1 });

        for (int i = 1; i < numRows; i++)
        {
            List<int> prevRow = (List<int>)triangle[i - 1];
            List<int> newRow = new List<int> { 1 };

            for (int j = 1; j < prevRow.Count; j++)
            {
                newRow.Add(prevRow[j - 1] + prevRow[j]);
            }
            newRow.Add(1);
            triangle.Add(newRow);
        }
        return triangle;
    }
}

// time complexity: O(n^2) where n is the number of rows in the triangle 
// space complexity: The triangle list stores all rows, and each row has i + 1 elements. So the space complexity is O(n^2) where n is the number of rows in the triangle.