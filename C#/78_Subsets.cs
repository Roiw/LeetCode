
// Solution 1: Iterative
public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        // Initialize the answer.
        List<IList<int>> ans = new List<IList<int>>();
        
        // Add first element 'empty'
        ans.Add(new List<int>());
        
        // Foreach int in nums
        foreach(int n in nums) {
            // Foreach answer in ans.
            int count = ans.Count;
            for (int i = 0; i < count; i++){
                List<int> toAdd = new List<int>(ans[i]);
                toAdd.Add(n);
                ans.Add(toAdd);
            }
        }
        return ans;
    }  
}

/*
     Solution 2: Backtracking

    The subsets can be of size [_] or [_,_] or [_,_,_] or ... [N] up to size N = nums.Length
    
    This can be thought as a decision tree (backtracking problem):
        
        The decision: 
            For each position of the subset we can pick a number from nums to place on that position            
        
        Algorithm:
            Starting with an empty list call a recursive function to select a element for the subset
            After every pick we can add the element to the list of subsets
            Use a hashset to make sure we are not adding the same elements

*/
public class Solution {
    
    private List<IList<int>> _subsets;
    
    private void GenerateSubsets(List<int> subset, int[] nums, int pos) {
        
        // Always add the subset
        _subsets.Add(new List<int>(subset));
        
        for (int i = pos; i < nums.Length; i++) {
            subset.Add(nums[i]);
            GenerateSubsets(subset, nums, i + 1);
            subset.Remove(nums[i]);
        }        
    }
    
    public IList<IList<int>> Subsets(int[] nums) {
        _subsets = new List<IList<int>>();
        GenerateSubsets(new List<int>(), nums, 0);
        return _subsets;
    }
}
