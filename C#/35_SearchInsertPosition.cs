public class Solution {
    public int SearchInsert(int[] nums, int target) {
        // Using C# BinarySearch library..
        //int e = Array.BinarySearch(nums, target);
        //return e < 0? ~e : e;
        // Using own Binary Search
        return FindIndex(nums, target, 0, nums.Length-1);
    }

    private int FindIndex(int[] nums, int target, int min, int max){
        if (min > max) return min; 
        int mid = (min + max)/2;
        if (target == nums[mid]) return mid;
        if (target > nums[mid]) return FindIndex(nums, target, mid+1, max);
        else return FindIndex(nums, target, min, mid-1); 
    }
}
