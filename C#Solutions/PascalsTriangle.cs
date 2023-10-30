public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        // Declaration of Nested IList output
        IList<IList<int>> triangle = new List<IList<int>>();

        // Iterate through for the number of rows required
        for (int i = 0; i < numRows; i++)
        {
            // Create a new list to represent the row of the pascal triangle and add 1 to the start of each row
            IList<int> row = new List<int>();
            row.Add(1);

            // For every row after the first row
            if (i > 0)
            {
                // Perform a nested loop iterating for the number of elements that should be in the row
                for (int j = 1; j < i; j++)
                {
                    // Calculate the value of the element to be added to the row based on the values of the previous row
                    int value = triangle[i-1][j-1] + triangle[i-1][j];
                    row.Add(value); 
                }

                // Add a final value of 1 to the end of the row
                row.Add(1);
            }

            // Add the row to the Pascal's Triangle List
            triangle.Add(row);
        }
        // Return the triangle after all calculations have been performed
        return triangle;
    }
}