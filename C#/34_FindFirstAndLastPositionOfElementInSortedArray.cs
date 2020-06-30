// 28
public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if(nums.Length == 0) return new int[] { -1, -1 };
        int lower = FindBound(nums, target, 0, nums.Length - 1, true);
        int upper = FindBound(nums, target, 0, nums.Length - 1, false);
        return new int[] {Math.Max(lower, -1), Math.Max(upper, -1)};
    }
    
    private int FindBound(int[] nums, int target, int x, int y, bool lower) {
        
        int mid = (x + y) / 2;
        if (x > y) return ~x; // Not present in array..
        
        // Go right..
        if (nums[mid] < target) { return FindBound(nums, target, mid + 1, y, lower); }
        // Go left..
        if (nums[mid] > target) { return FindBound(nums, target, x, mid - 1, lower); }
        else {
            // Case equal, check if we have the correct bound..
            if (lower) { 
                if ( mid == 0 || mid > 0 && nums[mid-1] != target)
                    return mid;   // Found a lower..
                else 
                    return FindBound(nums, target, 0, mid - 1, lower); // Go left..
            }
            else {
                int lastPos = nums.Length - 1;
                if ( mid == lastPos || mid < lastPos && nums[mid + 1] != target)
                    return mid; // Found a upper..
                else 
                    return FindBound(nums, target, mid + 1, nums.Length-1, lower); // Go right..
            } 
        }
    }
}
