public class Solution {
    private void FindSequence(List<IList<int>> combinations, List<int> temp, int n, int k, int curr) {
        if (temp.Count == k)
            combinations.Add(new List<int>(temp));       
        for(int i = curr + 1; i <= n; i++) {
            temp.Add(i);
            FindSequence(combinations, temp, n, k, i);
            temp.RemoveAt(temp.Count-1);
        }        
    }
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> ans = new List<IList<int>>();
        FindSequence(ans, new List<int>(), n, k, 0);
        return ans;
    }
}
