public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return 1;
        int curr = 0;
        for (int i = 1; i < nums.Length; i++){
            if (nums[i] != nums[curr]){
                curr++;
                nums[curr] = nums[i];
            }
        }
        return curr + 1;
    }
}
