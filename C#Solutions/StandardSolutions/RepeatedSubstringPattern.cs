public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        // Declare a storage variable to store current substring
        String substring = "";
        
        // Iterate through each possible substring variation
        for (int i = 1; i < s.Length; i++)
        {
            // Declare a variable to store the number of times the substring was found
            int strCount = 0;
            
            // Find the next possible substring
            substring = s.Substring(0, i);
            // Split the string into substring chunks
            String[] strlist = s.Split(substring);

            // For each individual split
            foreach (string part in strlist)
            {
                // If the substring does not equal null that means the substring doesn't fit
                // Break the loop and move to the next possible substring
                if (part != "") { break; }

                // Else add a counter to the substring count
                else { strCount ++; }

                // If the number of times the valid substring occurred matches the length of the original string return true
                if (strCount * substring.Length == s.Length) { return true; }
            }
        }
        // If no valid condition matches true, return false
        return false;
    }
}