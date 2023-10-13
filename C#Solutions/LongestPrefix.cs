public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        // As all words in the array must contain the same starting characters to have a common prefix
        // Sorting the input array will present the most juxtaposing words at the start and end of the array
        Array.Sort(strs);

        // Create a StringBuilder to store the output as we will perform string appending
        StringBuilder output = new();

        // Store the first and last word of the array for easier processing
        String firstWord = strs[0];
        String lastWord = strs[strs.Length-1];

        // Iterate through the first word comparing each letter to the last word
        for(int i = 0; i < firstWord.Length; i++)
        {
            // If any letter no longer matches, break the sequence and return the output string
            if(firstWord[i] != lastWord[i])
            {
                break;
            } else {
                // If the two letters match, append it to the output prefix string
                output.Append(firstWord[i]);
            }
        }
        // Convert the StringBuilder to a string output and return it
        return output.ToString();
    }
}