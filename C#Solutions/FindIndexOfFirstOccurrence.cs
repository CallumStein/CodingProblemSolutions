public class Solution {
    public int StrStr(string haystack, string needle) {
        
        // First Solution - C# Specific
        
        // Return index of the String function IndexOf which determines first occurence of char/string
        //return haystack.IndexOf(needle);

        // Second Solution - Programatic Solution

        // Iterate through the haystack
        for(int i = 0; i < haystack.Length; i++)
        {
            // Calculate the index endpoint of needle string
            int lengthOfNeedle = needle.Length + i;
            // As long as the end of the haystack has not been reached
            if (lengthOfNeedle <= haystack.Length)
            {
                // Use index range operations to compare the haystack to the needle at needle length increments
                if (haystack[i..(lengthOfNeedle)] == needle)
                {
                    // If needle is found, return the first index
                    return i;
                }
            }
        }
        // Else if no needle is found return -1
        return -1;
    }
}