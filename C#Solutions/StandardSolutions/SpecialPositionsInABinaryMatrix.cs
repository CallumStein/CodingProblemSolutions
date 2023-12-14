public class Solution {
    public int NumSpecial(int[][] mat) {
        // Declare a variable to store the count
        int count = 0;

        // Loop through the matrix
        for (int i = 0; i < mat.Length; i++)
        {
            // Establish Column and Row Counters
            int rowCount = 0;
            int colCount = 0;

            // Iterate through each position in the row
            for (int j = 0; j <mat[i].Length; j++)
            {
                // If a 1 is detected is detected at the current position
                if (mat[i][j] == 1) 
                {
                    // Increase the row counter by 1
                    rowCount++;
                    // Check each position of the column the 1 was detected in
                    for (int k = 0; k < mat.Length; k++)
                    {
                        // If any 1 positions are detected
                        if (mat[k][j] == 1)
                        {
                            // Increase the column counter by 1
                            colCount++;
                        }
                    }
                }
            }

            // After passing over every position of the current row, the row and column counter should be equal to 1 if any special positions were found
            if (rowCount == 1 && colCount == 1) { count++; }
        }
        // After a full scan of the matrix, return the count of special positions
        return count;
    }
}