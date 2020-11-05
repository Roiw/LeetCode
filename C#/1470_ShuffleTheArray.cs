public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        
        int[] ans = new int[nums.Length];
        int p0 = 0;
        int p1 = n;
        for (int i = 0; i < nums.Length; i++) {
            ans[i] = nums[p0];
            i++;
            ans[i] = nums[p1];
            p0++;
            p1++;
        }
        return ans;
    }
}
