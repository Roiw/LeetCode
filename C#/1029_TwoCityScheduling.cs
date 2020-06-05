public class Solution {
    // 1 - We put all people on city A 
    // 2 - We than get the smallest different B - A and move to city B
    // 3 - The result is price A's + price B's
    public int TwoCitySchedCost(int[][] costs) {
        SortedDictionary<int, Stack<int>> diffs = new SortedDictionary<int, Stack<int>>();
        for (int i = 0; i < costs.Length; i++) {
            int diff = costs[i][1] - costs[i][0];
            diffs.TryAdd(diff, new Stack<int>());
            diffs[diff].Push(i);
        }
        int ans = 0, j = 0;
        foreach (KeyValuePair<int,Stack<int>> d in diffs){
            while(d.Value.Count > 0){
                int n = d.Value.Pop();
                ans += j < costs.Length/2? costs[n][1]:costs[n][0];
                j++;
            }
        }
        return ans;
    }
}
