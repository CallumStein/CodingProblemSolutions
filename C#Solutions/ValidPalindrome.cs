public class Solution {
    public bool IsPalindrome(string s) {

        string output = "";
        

        for (int i = 0; i < s.Length; i++)
        {
            
            if (Char.IsLetterOrDigit(s[i])) 
            { 
                output += Char.ToLower(s[i]); 
            }
            else 
            { 
                output += ""; 
            }
        }

        int left = 0;
        int right = output.Length - 1;

        while (left < right)
        {
            if (output[left] != output[right]) { return false; }
            left++;
            right--;
        }

        return true;
    }
}