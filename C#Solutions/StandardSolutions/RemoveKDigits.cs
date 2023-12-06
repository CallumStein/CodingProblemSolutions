public class Solution {
    public string RemoveKdigits(string num, int k) {
        // Declare StringBuilder variable to function as Monotonic Stack
        var sb = new StringBuilder();

        // Create early exit case where k is equal to the length of num
        if (k == num.Length) { return "0"; }

        // Iterate through num starting from most significant digit (Left)
        for (int i = 0; i < num.Length; i++)
        {
            
            // If the current digit is less than the previous digit, remove the previous digit from the output
            while (k > 0 && sb.Length > 0 && Char.GetNumericValue(num[i]) < Char.GetNumericValue(sb[^1]))
            {
                // Reduce the count of digits to be removed and continue the loop
                sb.Remove(sb.Length-1, 1);
                k--;
            }
            // Add the current digit to the String output stack and continue the loop
            sb.Append(num[i]);
        }

        // Perform a final iteration if any value of k still remains
        while (k > 0)
        {
            // If digits still need to be removed, remove them from the end of the string
            sb.Remove(sb.Length-1, 1);
            k--;
        }

        // Remove any leading zeroes from the output before returning it
        String output = sb.ToString().TrimStart('0');
        if (output == "") { output = "0"; }

        return output;
        
    }
}