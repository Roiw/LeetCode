public class Solution {
    private List<IList<int>> _ans; 
    public IList<IList<int>> PermuteUnique(int[] nums) {
        _ans = new List<IList<int>>();
        FindPermutations(nums, 0);
        return _ans;
    }
    
    private void FindPermutations(int[] nums, int index) {
        
        if (nums.Length == index) {
            _ans.Add(nums.ToList());
            return;
        }
        
        HashSet<int> uniques = new HashSet<int>();
        
        for (int i = index; i < nums.Length; i++){
            if(!uniques.Add(nums[i])) continue;
            Swap(nums, i, index);
            FindPermutations(nums, index + 1);
            Swap(nums, i, index);
        }
        
    }
    
    private void Swap(int[] nums, int a, int b){
        if (a == b)
            return;
        int t = nums[a];
        nums[a] = nums[b];
        nums[b] = t;
    }    
}
