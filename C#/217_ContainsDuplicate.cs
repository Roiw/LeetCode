public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++){
            if(!hs.Add(i)) {
                return false;
            }
        }
        return true;
    }
}
