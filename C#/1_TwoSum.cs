public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // Brute force..
        for(int i = 0; i < nums.Length; i++) {
            for(int j = i + 1; j < nums.Length; j++) {
                if ( nums[i] + nums[j] == target)
                    return new int[2]{i,j};
                }
    	}
         return new int[2];
    } 
}


/* 
    - Hash O(N), S(N)
        The idea is to create a hash with nums.
        foreach element in nums we look for the 'complement' on the hash
            if it exist on the hash we can look for it's index on the following positions.
    
    */

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        HashSet<int> elems = new HashSet<int>(nums);
        for (int i = 0; i < nums.Length; i++) {
            int pair = target - nums[i];
            if (!elems.Contains(pair))
                continue;
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[j] == pair)
                    return new int[]{i,j};
            }               
        }
        return new int[]{-1,-1};
    }
}