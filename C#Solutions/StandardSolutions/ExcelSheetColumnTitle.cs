public class Solution {
    public string ConvertToTitle(int columnNumber) {
        // Dictionary for Alphabet Reference
        Dictionary<int, string> alphabet =  
              new Dictionary<int, string>(){
                    {1, "A"}, {2, "B"}, {3, "C"}, {4, "D"},
                    {5, "E"}, {6, "F"}, {7, "G"}, {8, "H"},
                    {9, "I"}, {10, "J"}, {11, "K"}, {12, "L"},
                    {13, "M"}, {14, "N"}, {15, "O"}, {16, "P"},
                    {17, "Q"}, {18, "R"}, {19, "S"}, {20, "T"},
                    {21, "U"}, {22, "V"}, {23, "W"}, {24, "X"},
                    {25, "Y"}, {26, "Z"}
              };

        // Processing Variables to store information
        StringBuilder sb = new StringBuilder("");

        // While the column number is greater than or equal 26 add each column letter to the output string by finding the modulus
        while (columnNumber >= 26)
        {
            // In the case where the key is zero, it must mean Z should be added to the letter
            int key = (columnNumber % 26 == 0) ? 26 : columnNumber % 26;
      
            // Add the modulus result of the current number to the start the string builder building column number in reverse
            sb.Insert(0, (alphabet.ContainsKey(key)) ? alphabet[key] : "");
            
            // shift the column number by 26 to find the next column value
            // In the case where the key was 26 'Z', the remaining number should be shifted by 1 less 
            columnNumber = (key == 26) ? (columnNumber / 26) -1 : columnNumber / 26;
        }
        
        // Perform one final reference look up and add the final letter to the front of the string
        sb.Insert(0, (alphabet.ContainsKey(columnNumber)) ? alphabet[columnNumber] : "");

        // Convert the StringBuilder object to a string and return it
        return sb.ToString();
    }
}