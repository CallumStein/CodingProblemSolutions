public class Solution {
    public bool IsValid(string s) {
        // Create a reference map for bracket configurations
        Dictionary<char, char> bracketsMap = new Dictionary<char, char> {
            {'{', '}'},
            {'[', ']'},
            {'(', ')'}
        };

        // Declare a Stack data structure (inbuilt C#) to store open brackets as they're found
        Stack<char> openBrackets = new Stack<char>();

        // Iterate through each character of the input string, foreach used as index manipulation not necessary
        foreach (char currentBracket in s) 
        {
            // If the current character is an open bracket found in the bracket map add it to the stack
            if (bracketsMap.ContainsKey(currentBracket))
            {
                openBrackets.Push(currentBracket);
            }
            // Else if the current character is a closed bracket, compare it to the latest stacked bracket to see if it matches
            else
            {
                // In the case that the first character scanned of the string is a closed bracket, the stack will be empty and invalid
                if (openBrackets.Count == 0)
                {
                    // In this case return false as the whole input string is invalid
                    return false;
                }

                // Remove the last item from the stack and use the reference map to get it's corresponding closed bracket for comparison
                if (bracketsMap[openBrackets.Pop()] != currentBracket)
                {
                    // If the latest open bracket and current closed bracket do not create a valid parentheses, return false
                    return false;
                }
            }
        }
        // At the end of the process, the stack of open brackets should be empty, return the boolean comparison
        return openBrackets.Count == 0;
    }
}