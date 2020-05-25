public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        int[] ans = new int[nums.Length];
        bool loop = false;
        for (int i = 0; i < nums.Length; i++){
            int j = i + 1;
            ans[i] = -1;
            while (j != i) { 
                if (j < nums.Length && nums[j] > nums[i]) {
                    ans[i] = nums[j];
                    break;
                }         
                j = j == nums.Length ? 0 : j + 1;
            }
        }
        return ans;
    }
}
