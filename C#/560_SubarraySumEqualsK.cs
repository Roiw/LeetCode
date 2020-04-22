public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int t = 0;
        for (int i = 0; i < nums.Length; i++){
            int s = 0;
            for (int j = i; j < nums.Length; j++){
               s += nums[j];
               if (s == k) t++;
            }
        }
        return t;
    }
}
