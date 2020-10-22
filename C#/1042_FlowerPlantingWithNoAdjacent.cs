/*
    
    The Plan:
        - DFS to navigate on nodes.
        - When on a node check all it's neighbors to select the correct plant
    
*/


public class Solution {
    
    Dictionary<int, List<int>> graph;
    HashSet<int> visited;
    int[] answer;
    
    public void Plant(int node){
        if (visited.Contains(node))
            return;
        
        visited.Add(node);
        
        // Check every neighbor.
        HashSet<int> possible = new HashSet<int>() {1, 2, 3, 4};
        foreach (int neighbor in graph[node]) {
            possible.Remove(answer[neighbor-1]);
        }
        answer[node - 1] = possible.First();
        
        foreach (int neighbor in graph[node]) {
            Plant(neighbor);
        }    
    }
    
    public int[] GardenNoAdj(int n, int[][] paths) {
        graph = new Dictionary<int, List<int>>();
        foreach (int[] p in paths) {
            if (!graph.TryAdd(p[0], new List<int> { p[1] }))
                graph[p[0]].Add(p[1]);
            if (!graph.TryAdd(p[1], new List<int> { p[0] }))
                graph[p[1]].Add(p[0]);
        }
        
        visited = new HashSet<int>();
        answer = new int[n];
        
        foreach (int node in graph.Keys) {
            Plant(node);
        }
        
        return answer.Select(x => x == 0? 1 : x).ToArray();
        
    }
}
