public class Solution {
    public bool IsIsomorphic(string s, string t) {
        // Edge case for none matching string lengths
        if (s.Length != t.Length) { return false; }

        // Declare a storage dictionary to map each character of 1st string to a specific character in the 2nd
        Dictionary<char, char> sDict = new Dictionary<char, char>();
        Dictionary<char, char> tDict = new Dictionary<char, char>();

        // Iterate through the two strings
        for (int i = 0; i < s.Length; i++)
        {
            // Check if the current character has already been seen in 's'
            if (sDict.ContainsKey(s[i]) == true) 
            { 
                // If the current character does not map to the previously found character return false
                if (sDict[s[i]] != t[i]) { return false; } 
            }
            else
            {
                // Else if its a new character, map it to the corresponding t character
                sDict.Add(s[i], t[i]);
            }

            // Check if the current character has already been seen in 't'
            if (tDict.ContainsKey(t[i]) == true) 
            { 
                // If the current character does not map to the previously found character return false
                if (tDict[t[i]] != s[i]) { return false; } 
            }
            else
            {
                // Else if its a new character, map it to the corresponding s character
                tDict.Add(t[i], s[i]);
            }
        }

        // If all checks pass return true 
        return true;
    }
}