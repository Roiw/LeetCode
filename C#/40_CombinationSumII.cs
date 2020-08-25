public class Solution {
    public void DFS (List<IList<int>> ans, List<int> comb, int[] arr, int start, int sub) {
        if(sub == 0) {
            ans.Add(new List<int>(comb));
        }
                    
        if (sub > 0) {
            for (int i = start; i < arr.Length; i++) {
                // Avoid repetitions by only starting from a number one time.
                if (i > start && arr[i-1] == arr[i])
                    continue;
                
                comb.Add(arr[i]);
                DFS(ans, comb, arr, i + 1, sub - arr[i]);
                comb.RemoveAt(comb.Count - 1);
            }
        }
    }
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        Array.Sort(candidates);
        List<IList<int>> ans = new List<IList<int>>();
        DFS(ans, new List<int>(), candidates, 0, target);
        return ans;
    }
}
