public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return 1;
        if (nums.Length == 2) return 2;
        
        int pivot1 = 0; // The index of the last inserted element..
        int pivot2 = 2; // position we need to insert a new element on the array..
        
        for (int i = 2; i < nums.Length; i++){
            if (nums[i] != nums[pivot1]){
                pivot1++;
                nums[pivot2] = nums[i];
                pivot2++;
            }   
        }
        return pivot2;
    }
}
