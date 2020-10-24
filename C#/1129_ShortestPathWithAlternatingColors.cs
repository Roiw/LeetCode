/*
    
    - Map edges to Map or Dictionary for easy access (each color)
    - BFS, minding the colors.
    - Hashset to keep visisted vertices out (each color)
    - A min vector.
*/

public class Solution {
    private Dictionary<int, List<int>> blues;
    private Dictionary<int, List<int>> reds;
    private HashSet<int> visitedBlue;
    private HashSet<int> visitedRed;
    public int[] ShortestAlternatingPaths(int n, int[][] red_edges, int[][] blue_edges) {
        
        blues = new Dictionary<int,List<int>>();
        reds =  new Dictionary<int,List<int>>();
        
        foreach (int[] edge in red_edges) {
            if (!reds.TryAdd(edge[0], new List<int> { edge[1] }))
                reds[edge[0]].Add(edge[1]);
        }
        
        foreach (int[] edge in blue_edges) {
            if (!blues.TryAdd(edge[0], new List<int> { edge[1] }))
                blues[edge[0]].Add(edge[1]);
        }
        
        visitedBlue = new HashSet<int>();
        visitedRed = new HashSet<int>();
        
        int[] ans = new int[n].Select(x => -1).ToArray();
        
        Queue<(int, int, bool)> queue = new Queue<(int,int, bool)>();
        queue.Enqueue((0, 0, true));
        queue.Enqueue((0, 0, false));
        
        while (queue.Count > 0) {
            (int node, int d, bool acceptBlue) = queue.Dequeue();
            
            ans[node] = ans[node] == -1? d : Math.Min(ans[node], d);
            
            var dic = acceptBlue ? blues : reds;
            var vis = acceptBlue ? visitedBlue : visitedRed;
            
            if (!dic.ContainsKey(node)) continue;
            
            foreach (int neighbor in dic[node]) {
                if (!vis.Contains(neighbor)){
                    vis.Add(neighbor);
                    queue.Enqueue((neighbor, d + 1, !acceptBlue));
                }   
            } 
        }
        return ans;
    }
}
