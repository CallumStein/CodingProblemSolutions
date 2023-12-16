public class Solution {
    public bool RepeatedSubstringPattern(string s) {
        // The idea behind this approach is that if a string s can be constructed by repeating a substring, 
        // then concatenating two copies of s together and removing the first and last character would still contain s as a substring.

        // Concatinate the original string to itself
        string doubled = s + s;
        // obtain the modified string excluding the first and last character
        string sub = doubled.Substring(1, doubled.Length - 2);
        // Return the boolean result of whether the modified string contains a possible character combination of the original
        return sub.Contains(s);
    }
}