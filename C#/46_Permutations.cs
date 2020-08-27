public class Solution {
    
    // Avoid clutting headers by creating a global var.
    private List<IList<int>> _ans;
    
    // Helper function..
    private void Swap(int[] nums, int a, int b) {
        int aux = nums[a];
        nums[a] = nums[b];
        nums[b] = aux;
    }
    
    // Generates all the permutations..
    private void GeneratePermutations(int[] nums, int index) {
        if (index == nums.Length)
            _ans.Add(new List<int>(nums));
        
        for (int i = index; i < nums.Length; i++) {
            Swap(nums, i, index); // Swap..
            GeneratePermutations(nums, index + 1);
            Swap(nums, i, index); // Unswap..
        }
    }
    
    public IList<IList<int>> Permute(int[] nums) {
        _ans = new List<IList<int>>();
        GeneratePermutations(nums, 0);
        return _ans;
    }
}