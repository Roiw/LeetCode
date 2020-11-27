// Using Floyd-Warshall to define the shortest path to all nodes.

public class Solution {    
    public int FindTheCity(int n, int[][] edges, int distanceThreshold) {
        
        int[,] memo = new int[n,n];
        
        // Initializing
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                memo[i,j] = i == j ? 0 : 100000;
            }
        }
        
        // Populating the matrix.
        foreach (var info in edges) {
            memo[info[0], info[1]] = info[2];
            memo[info[1], info[0]] = info[2];
        }
        
        // Generating all the minimum paths between nodes O(N3)
        // Using Floyd-Warshall
        for (int k = 0; k < n; k++) {
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    memo[i,j] = Math.Min(memo[i,j], memo[i,k] + memo[k,j]);
                }
            }
        }
        
        // Finding the minimum.
        int min = 0;
        int minValue = Int32.MaxValue;
        for (int i = 0; i < n; i++) {
            int count = 0;
            for (int j = 0; j < n; j++) {
                count += memo[i,j] <= distanceThreshold? 1 : 0;
            }
            if (count <= minValue) {
                minValue = count;
                min = i;
            } 
        }
        return min;
    }
}
