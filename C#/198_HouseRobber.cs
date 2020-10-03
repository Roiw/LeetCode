/*

    For a house at index N we must choose between:
        - The max of the array that ends in index N - 2 + value at N
        - value at N - 1.
    
    Eg:
    [1, 2, 3, 1] ->  Pick between 3 + 1 or 2. We pick 4.
     ^  ^  ^
    
    [1,  2,  4,  1] -> Pick between 2 + 1 or 4. We pick 4.
         ^   ^   ^
    
    [1,  2,  4,  4] -> End of array.

*/

public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return nums[0];
        if (nums.Length == 2) return Math.Max(nums[0], nums[1]);
        
        for (int i = 2; i < nums.Length; i++) {
            nums[i] = Math.Max(nums[i - 2] + nums[i], nums[i - 1]);
            nums[i - 1] = Math.Max(nums[i - 2], nums[i - 1]);
        }
        return nums.Last();
    }
}
