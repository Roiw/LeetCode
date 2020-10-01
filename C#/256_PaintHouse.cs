/*

    53 - 59 (working solution)
    00 - 11 (memoization upgrade)

    Backtracking problem.
        - Foreach house I can pick a one of three colors. 
        - I can't select a color that I've previously selected.
        - Memoize to improve performance.

*/

public class Solution {
    
    private Dictionary<(int, int), int> _memo;
    
    public int SelectHouse(int[][] costs, int lastPainted, int pos) {
        
        if (pos == costs.Length)
            return 0;
        
        var key = (pos, lastPainted);
        
        if (_memo.ContainsKey(key))
            return _memo[key];
        
        int minCost = Int32.MaxValue;
        
        for (int i = 0; i < costs[pos].Length; i++) {
            if (i == lastPainted) continue;
            minCost = Math.Min(minCost, costs[pos][i] + SelectHouse(costs, i, pos + 1));
        }
        
        _memo.Add(key, minCost);
        
        return minCost;
    }
    
    public int MinCost(int[][] costs) {
        _memo = new Dictionary<(int,int), int>();
        if (costs.Length == 0) return 0;
        return SelectHouse(costs, -1, 0);
    }
}
