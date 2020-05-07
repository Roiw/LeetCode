public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
        
        foreach( int i in nums) {
            count.TryAdd(i,0);
            count[i]++;
            if (count[i] > nums.Length /2)
                return i;
        }
        return -1;
    }
}
