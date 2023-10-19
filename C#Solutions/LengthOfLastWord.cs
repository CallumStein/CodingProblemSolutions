public class Solution {
    public int LengthOfLastWord(string s) {

        // First Solution

        // Clean the input string and seperate it into an array
        //string[] words = s.Trim().Split(' ');
        // Return the length of the last word in the split array
        //return words[words.Length-1].Length;

        // Second Solution

        // Clean all trailing white spaces from input string 
        s = s.TrimEnd();
        int wordLength = 0;

        // Iterate through string backwards
        for (int i = s.Length - 1; i >= 0; i--)
        {
            // Look for ' ' char
            if (s[i] == ' ')
            {
                break;
            }
            // Increase word length count
            wordLength++;
        }
        // Return the word length
        return wordLength;
    }
}