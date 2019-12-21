public class Solution {
    public int FindPeakElement(int[] nums) {
        
        if (nums.Length == 1)
            return 0;
        
        for (int i  = 0; i  < nums.Length; i++) {       
            if (i == nums.Length -1) {
                if (nums[i-1] < nums[i])
                    return i;
                continue;
            }         
            if (i == 0) {
                if (nums[i+1] < nums[i])
                    return i;
                continue;
            }             
            if (nums[i-1] < nums[i] && nums[i+1] < nums[i])
                return i;
        }
        return -1;
        
    }
}
