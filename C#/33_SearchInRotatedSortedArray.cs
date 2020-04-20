public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0) return -1;
        return Find(nums, target, 0, nums.Length);
    }
    public int Find(int[] nums, int target, int s, int len){
        
        if (nums[s] == target)
            return s;
            
        if (len == 1 && nums[s] != target)
            return -1;
        
        // not on this array..
        if (nums[s] < nums[s+len-1] && (nums[s] > target || nums[s+len-1] < target) )
            return -1;
        
        // could be on this array so we split..
        int l = Find(nums, target, s, len/2);
        int r = Find(nums, target, s+len/2, len%2 == 0 ? len/2 : (len/2) +1);
        
        if (l != -1) return l;
        if (r != -1) return r;
        return -1;
    }
}
