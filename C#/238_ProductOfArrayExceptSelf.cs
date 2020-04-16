public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans = new int[nums.Length];
        
        ans[nums.Length - 1] = nums[nums.Length - 1];
        for (int i  = nums.Length - 2 ; i >= 0; i--){
            ans[i] = nums[i] * ans[i + 1];
        }
         
        for (int i = 1; i < nums.Length; i++){
            nums[i] = nums[i] * nums[i - 1];
        }
        
        ans[0] = ans[1];
        
        for (int i  = 1; i < nums.Length - 1; i++){
            ans[i] = nums[i-1] * ans[i+1];
        }

        ans[nums.Length-1] = nums[nums.Length-2];
        
        return ans;
    }
}
