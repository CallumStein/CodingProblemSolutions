public class Solution {
    public IList<int> GetRow(int rowIndex) {
        // Declare output list to store the nth row
        List<int> pascalsRow = new List<int>();
        
        // Any nth row of Pascal's Triangle starts at 1
        pascalsRow.Add(1);

        // For each nth row, there are n + 1 elements. Eg: row 4 has 5 elements
        // Iterate through each element calculating the ith element using binomial coefficient formula
        for (int i = 1; i < rowIndex + 1; i++)
        {
            // Use the previous element in the row to calculate the next
            long nextValue = (long)pascalsRow[i-1] * (rowIndex - i + 1) / i;
            pascalsRow.Add((int)nextValue);
        }

        // Return the row
        return pascalsRow;
    }
}