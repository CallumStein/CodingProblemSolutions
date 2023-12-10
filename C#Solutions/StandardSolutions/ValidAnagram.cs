public class Solution {
    public bool IsAnagram(string s, string t) {
        // Edge case for when the length of both strings do not match
        if (s.Length != t.Length) { return false; }

        // Declare a Dictionary to store the letter and count value for both strings
        Dictionary<char, int> letterCount = new Dictionary<char, int>();

        // Declare left and right pointers
        int left = 0;
        int right = s.Length - 1;

        // Iterate quickly through s to count all unique letters
        while (left <= right)
        {
            if (left == right)
            {
                // Check if the dictionary already contains the current letter on the left side for string 's'
                if (letterCount.ContainsKey(s[left])) { letterCount[s[left]]++; }
                else { letterCount.Add(s[left], 1); }
            }
            else
            {
                // Check if the dictionary already contains the current letter on the left side for string 's'
                if (letterCount.ContainsKey(s[left])) { letterCount[s[left]]++; }
                else { letterCount.Add(s[left], 1); }

                // Check if the dictionary already contains the current letter on the right side for string 's'
                if (letterCount.ContainsKey(s[right])) { letterCount[s[right]]++; }
                else { letterCount.Add(s[right], 1); }
            }

            // Increment Left and Right pointers
            left++;
            right--;
        }

        // Iterate through t comparing to the distinct letters found in s
        for (int i = 0; i < t.Length; i++)
        {
            // If the current character exists in s as well decrement the count by 1
            if (letterCount.ContainsKey(t[i]))
            {
                letterCount[t[i]] -= 1;
            }
            // Else if the character doesn't exist at all, return false
            else { return false; }
        }

        // Check that all values in the letterCount are equal to zero and return true if valid
        if (letterCount.Values.All(val => val == 0)) { return true; }

        // Otherwise return false
        return false;
    }
}