public class Solution {
    public IList<int> FindDuplicates(int[] nums) {
        HashSet<int> hs = new HashSet<int>();
        List<int> duplicates = new List<int>();
        foreach (int i in nums) {
            if (!hs.Add(i)) duplicates.Add(i);
        }
        return duplicates;
    }
}
