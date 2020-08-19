public class Solution {
    private int BinarySearch(int[] arr, int min, int max) {
        int mid = min + (max-min)/2;
        bool biggerThanLeft = mid == 0 || mid > 0 && arr[mid] > arr[mid-1];
        bool biggerThanRight = mid == arr.Length-1 || mid < arr.Length-1 && arr[mid] > arr[mid+1];
        
        if (biggerThanRight && biggerThanLeft)
            return mid;
        if (biggerThanRight)
            return BinarySearch(arr, min, mid - 1);
        else
            return BinarySearch(arr, mid + 1, max);
    }
    
    public int FindPeakElement(int[] nums) {
        return BinarySearch(nums, 0, nums.Length-1);
    }
}
