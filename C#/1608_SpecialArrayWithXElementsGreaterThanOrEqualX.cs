public class Solution {
    public int SpecialArray(int[] nums) {
        Array.Sort(nums);
        int j = 0;
        for (int i = 1; i <= nums.Length; i++) {
            while (nums[j] < i) {
                j++;
                if (j == nums.Length) return -1;
            }        
            if (nums[j] >= i && nums.Length - j == i)  
                return i;  
        }
        return -1;
    }
}