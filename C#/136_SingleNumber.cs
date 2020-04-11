public class Solution {
    public int SingleNumber(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (!hs.Add(nums[i]))
                hs.Remove(nums[i]);
        }
        List<int> l = hs.ToList();
        return l[0];
    }
}
