public class Solution {
    public string CustomSortString(string order, string s) {

        // Create a String Builder object for faster concatination
        var output = new System.Text.StringBuilder();
        // Create a lookup array that has 26 indexes mapped to the letters of the alphabet
        int[] map = new int[26];

        // For each character in the input string, add the count of appearance to the map
        for(int i = 0; i < s.Length; i++)
        {
            // Convert the character at the current index to a corresponding map index
            map[s[i] - 'a']++;
        }

        // For each character in the 'order' string, add the character from the map to the output if they match
        for(int i = 0; i < order.Length; i++)
        {
            // Uses the String Override Constructor - public String (char c, int count); the count is found from the map
            output.Append(new String(order[i], map[order[i] - 'a']));
            // As the character in order is unique, set its map value to zero
            map[order[i] - 'a'] = 0;
        }

        // For all remaining characters in the map that still have a count, add it to the output
        for(int i = 0; i < 26; i++)
        {
            // public String(char c, int count); Constructor approach to find remaining characters
            output.Append(new String((char)('a' + i), map[i]));
        }

        // Convert the output to a string and return it
        return output.ToString();
    }
}