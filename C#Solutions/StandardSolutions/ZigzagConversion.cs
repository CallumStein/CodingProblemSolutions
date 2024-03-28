public class Solution {
    public string Convert(string s, int numRows) {
        // Edge cases for fast returns
        if (numRows ==1 || s.Length <= 1) { return s; }

        // Declare a string storage array to store each zigzaged row
        string[] zigzag = new string[numRows];

        // Declare an index tracker for the row and a direction pointer (positive = right, negative = left)
        int row = 0;
        int zigzagDirection = 1;

        // Iterate through the input string
        for (int i = 0; i < s.Length; i++)
        {
            // Add the current character to the current row
            zigzag[row] += s[i];

            // Modify the row tracker based on the current direction
            row += zigzagDirection;

            // Check to see if the row tracker has reached the boundaries of the zigzag
            // Moving Left: row length - 1 - Moving Right: reached 0
            if (row == numRows-1 || row == 0)
            {
                // Flip the ZigZag direction
                zigzagDirection *= -1;
            }
        }

        // return the output concatenated together
        return string.Concat(zigzag);
    }
}