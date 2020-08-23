public class Solution {
    private void Combinations(List<IList<int>> ans, List<int> temp, int start , int[] candidates, int target, int sum) {
        if (sum == target) {
            ans.Add(new List<int>(temp));
            return;
        }
        if (sum > target)
            return;
        
        for (int i = start; i < candidates.Length; i++) {
            temp.Add(candidates[i]);
            Combinations(ans, temp, i, candidates, target, sum + candidates[i]);
            temp.RemoveAt(temp.Count-1);
        }  
    }
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        HashSet<string> verify = new HashSet<string>();
        List<IList<int>> ans = new List<IList<int>>();
        Combinations(ans, new List<int>(), 0, candidates, target, 0);
        return ans;
    }
}
