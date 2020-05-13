public class Solution {
    
    public int SingleNonDuplicate(int[] nums) {
        return Dive(nums, 0, nums.Length);
        
    }
    
    private int Dive(int[] nums, int start, int count){
        if (count == 1)return nums[start];
        if (count == 2){
            // Find who?
            if (start > 0 && nums[start] == nums[start-1])
                return nums[start+1];
            if (start+1 < nums.Length-1 && nums[start+1] == nums[start+2])
                return nums[start];
            
            if (start == 0) return nums[start];
            if (start+1 == nums.Length) return nums[start+1];
        }
        
        int mid  = (count/2) + start;
        if (mid % 2 == 0){
            if (nums[mid] == nums[mid-1]){
                // Its left of mid 
                return Dive(nums, start, count/2);
            }
            else {
                // its right of mid inclusive
                return Dive(nums, mid, count/2);
            }    
        }
        else {
            if (nums[mid] != nums[mid-1]){
                // Its left of mid
                return Dive(nums, start, count/2);
            }
            else {
                // its right of mid
                return Dive(nums, mid + 1, count/2);
            }
        }
        
    }
}
