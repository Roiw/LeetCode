public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> elemsFound = new HashSet<int>();
        HashSet<int> ans = new HashSet<int>(); 
        for(int i = 0; i < nums.Length; i++){
            if (elemsFound.Add(nums[i])){
                ans.Add(nums[i]);
            }
            else
                ans.Remove(nums[i]);
        }
        return ans.ToList()[0];
    }
}
