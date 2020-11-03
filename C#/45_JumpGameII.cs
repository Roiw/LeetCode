/*

    Dynamic Programming O(N)
    The Plan:
        - Get a value from the nums array. This is the number of STEPS we can consume until we need to jump again.
        - Verify the max range we can reach with that set of STEPS
        - After consuming all the STEPS, we increase our jump counter and add the remaining steps to reach max range.

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
