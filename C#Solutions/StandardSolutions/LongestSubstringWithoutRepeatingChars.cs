public class Solution {
    public int LengthOfLongestSubstring(string s) {
        // Declare a processing List to store unique characters and an integer to store the length of the longest substring
        List<char> previousChars = new List<char>();
        int longestSubstring = 0;
        
        // Perform a nested loop that scans for each variation of substrings within the original string
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i; j < s.Length; j++)
            {
                // If the current character of the substring is not within the previous char list, add it
                if (!previousChars.Contains(s[j]))
                {
                    previousChars.Add(s[j]);
                }
                // Else if the character is not unique
                else
                {
                    // Set the longest substring count if the current substring is larger than the previous one
                    longestSubstring = (previousChars.Count > longestSubstring) ? previousChars.Count : longestSubstring;
                    // Reset the processing list and break from the nested loop to iterate i to the next character
                    previousChars.Clear();
                    break;
                }
            }
        }
        // After all processing has been done perform one final check on the previous Char list and return the longest substring count
        longestSubstring = (previousChars.Count > longestSubstring) ? previousChars.Count : longestSubstring;
        return longestSubstring;
    }
}