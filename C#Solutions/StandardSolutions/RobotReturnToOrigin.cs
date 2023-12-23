public class Solution {
    public bool JudgeCircle(string moves) {
        // Store the coordinates of the robot
        int[] position = [0, 0];

        // Iterate through the movements of the robot
        for (int i = 0; i < moves.Length; i++)
        {
            // Create a switch case to adjust the X Y coordinates of the robot based on different commands
            switch(moves[i]) 
            {
                case 'U':
                    // Increase the Y coordinate by 1
                    position[1]++;
                    break;
                case 'R':
                    // Increase the X coordinate by 1
                    position[0]++;
                    break;
                case 'L':
                    // Decrease the X coordinate by 1
                    position[0]--;
                    break;
                case 'D':
                    // Decrease the Y coordinate by 1
                    position[1]--;
                    break;
                default:
                    // Do nothing
                    break;
            }
        }
        
        // Check whether the robot is at its origin position and return the result
        return position[0] == 0 && position[1] == 0;
    }
}