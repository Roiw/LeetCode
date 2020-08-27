public class Solution {
    
    private List<IList<int>> _ans;
    
    private void Swap(int[] nums, int a, int b) {
        int c   = nums[a];
        nums[a] = nums[b];
        nums[b] = c;
    }
    
    private void GeneratePermutations(int[] nums, int index) {
        
        if (nums.Length == index)
            _ans.Add(new List<int>(nums));
        
        HashSet<int> check = new HashSet<int>();
        
        for (int i = index; i < nums.Length; i++) {
            
            if (!check.Add(nums[i]))
                continue;
            
            Swap(nums, index, i); // Swap
            GeneratePermutations(nums, index + 1);
            Swap(nums, index, i); // Restore
        }
        
    }
    public IList<IList<int>> PermuteUnique(int[] nums) {
        _ans = new List<IList<int>>();
        GeneratePermutations(nums, 0);
        return _ans;
    }
}
