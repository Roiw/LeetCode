public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
        int[] ans = new int[nums.Length];
        Dictionary<int,int> hm = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++) {
            int s = 0;
            // improv goes here..
            if (hm.ContainsKey(nums[i])){ // This avoid running through the whole array for repeated cases.
                ans[i] = hm[nums[i]];
                continue;
            }
            for (int j =0; j < nums.Length; j++){
                if (nums[i] > nums[j])
                    s++;
            }
            ans[i] = s;
            hm.Add(nums[i], s);
        }
        return ans;
    }
}