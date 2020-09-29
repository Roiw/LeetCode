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
    Dictionary solution O(N), S(N)
    One pass.

*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> elements = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            
            int needed = target - nums[i];
            
            if (elements.ContainsKey(needed)) 
                return new int[] {i, elements[needed]};
            
            elements.TryAdd(nums[i], i);
        }
        return null;
    }
}