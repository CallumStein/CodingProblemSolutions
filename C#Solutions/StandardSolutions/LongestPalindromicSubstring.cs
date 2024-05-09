public class Solution {
    public string LongestPalindrome(string s) {
        // Initialize processing variables
        String longestSubstring = "";
        int longestSubstringLength = 0;
        String substring = "";
        int substringLength = 0;

        // Boundary cases for early return
        if(s.Length <= 1)
        {
            return s;
        }

        // Boundary case for 2 character long string
        longestSubstring += s[0];
        longestSubstringLength++;

        // Iterate through each character forming substrings
        for(int i = 0; i < s.Length; i++)
        {
            // Store the first substring
            substring += s[i];
            substringLength = substring.Length;

            // For every other character, build out a new substring until the first char is found again
            for(int j = i+1; j < s.Length; j++)
            {
                // Concatinate to the substring as we process
                substring += s[j];

                // If the first character is found again
                if(s[i] == s[j])
                {
                    //Console.WriteLine("sub: " + substring + " Length: " + substringLength);

                    // update the processing variables
                    int length = substring.Length;
                    substringLength = substring.Length;
                    int left = 0;
                    int right = substring.Length - 1;

                    // Perform a left to right search checking that all characters match
                    while(left <= right)
                    {
                        // If ever the characters don't match break the sequence
                        if(substring[left] != substring[right])
                        {
                            substringLength = 0;
                            break;
                        }
                        left++;
                        right--;
                    }

                    // If the palindrome found is longer than the previously found one store it
                    if(substringLength >= longestSubstringLength)
                    {
                        longestSubstring = substring;
                        longestSubstringLength = substringLength;
                    }
                }
            }
            
            // Reset the substring and start again
            substring = "";
        }
        // After all processing, return the longest palindrome found
        return longestSubstring;
    }
}