public class Solution {
    private List<IList<int>> _ans;
    public IList<IList<int>> Permute(int[] nums) {
        _ans = new List<IList<int>>();
        GeneratePermutations(nums, 0);
        return _ans;
    }
    private void GeneratePermutations(int[] nums, int key) {
        
        // Base case, found a permutation..
        if (key == nums.Length) 
            _ans.Add(nums.ToList());
        
        for (int i = key; i < nums.Length; i++){
            
            // Perform a change
            int t = nums[i];
            nums[i] = nums[key];
            nums[key] = t;
            
            // Advance on the key.
            GeneratePermutations(nums, key +1);
            
            // Revert the change..
            t = nums[i];
            nums[i] = nums[key];
            nums[key] = t;
        }
    }
}
