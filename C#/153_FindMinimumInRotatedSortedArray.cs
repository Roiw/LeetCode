public class Solution {
    private int BinSearch(int[] nums, int min, int max) {
        if (min > max)
            return nums[min];
        int mid  = min + (max-min)/2;
        
        if (nums[mid] > nums[max]) 
            return BinSearch(nums, mid + 1, max);
        else if (mid > 0 && nums[mid - 1] <  nums[mid] )
            return BinSearch(nums, min, mid-1);
        else 
            return nums[mid];
    }
    public int FindMin(int[] nums) {
        return BinSearch(nums, 0, nums.Length-1); 
    }
}
