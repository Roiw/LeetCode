// Floyd's Tortoise and Hare (Cycle Detection)
// O(N) S(1)
// Hare moves twice as fast as the tortoise. The gap between their first intersection and the begining of the cycle 
// will be equal to the amout of steps the tortoise takes to get to the cycle.
public class Solution {
    public int FindDuplicate(int[] nums) {
        if (nums.Length == 0) return -1;
        int hare = 0, tortoise = 0;
        // Phase one (detect a cycle).
        do {
            tortoise = nums[tortoise];
            hare = nums[nums[hare]];
        } while (tortoise != hare);
        
        tortoise = 0;
        // Phase 2 find beginning of cycle.
        while (tortoise != hare) {
            hare = nums[hare];
            tortoise = nums[tortoise];
        }
        return hare;
    }
}
