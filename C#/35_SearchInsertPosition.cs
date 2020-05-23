public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if (target < nums[0]) return 0;
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] >= target)
                return i;
        }
        return nums.Length;
    }
}
