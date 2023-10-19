public class Solution {
    public string AddBinary(string a, string b) {
        // Declare sum variable
        string sum = "";
        double carry = 0;
        
        // Adjust the two inputs to be the same length
        if (a.Length < b.Length)
        {
            a = a.PadLeft(b.Length, '0');
        }
        else
        {
            b = b.PadLeft(a.Length, '0');
        }

        // Iterate backwards through the strings
        for (int i = a.Length - 1; i >= 0; i--)
        {
            // Convert characters to integers
            double digitA = char.GetNumericValue(a[i]);
            double digitB = char.GetNumericValue(b[i]);

            // Add values to the sum with base-2 modulus, add the digit to the front of the string
            sum = ((digitA + digitB + carry) % 2) + sum;
            
            // Calculate the carry, if the sum of the two digits is greater than 2 there must be a carry
            if (digitA + digitB + carry >= 2)
            {
                carry = 1;
            }
            else
            {
                carry = 0;
            }
        }

        // If the carry is still greater than zero after iterating, add the carry to the front of the sum
        if (carry == 1)
        {
            sum = carry + sum;
        }
        // Return the sum
        return sum;
    }
}