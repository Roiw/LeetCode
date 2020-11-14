/*

    Dynamic Programming O(N)

    The Plan:
        - Keep three variables, Jumps, MaxRange, CurrentRange
        - Jumps is the amount of jumps we took.
        - MaxRange is the maximum range we can reach, this is given by the max value that we jumped over.
        - CurrentRange is the amount of elements we can still jump over.
        - When CurrentRange reaches 0 we must get the MaxRange
            So CurrentRange becomes: MaxRange - i
        - For every new place we update MaxRange:
            MaxRange = Math.Max(MaxRange, nums[i] + i)
*/

public class Solution {
    public int Jump(int[] nums) {
        
        if (nums.Length == 1)
            return 0;
        
        int steps = nums[0]; // The amount of STEPS we can take until we jump again.
        int range = nums[0]; // How far we can reach
        int jumps = 1; // The amount of jumps we took.
        
        for (int i = 1; i < nums.Length; i++) { 
            
            range = Math.Max(range, nums[i] + i);
            
            if (i == nums.Length - 1)
                return jumps;
            
            steps--; // Consume a step.
            if (steps == 0) {
                steps = range - i; // We add the remaining steps to reach max range.
                jumps++;
            }
        }
        return jumps;
    }
}