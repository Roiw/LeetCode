// Bellman Ford (V*E)
public class Solution {    
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        Dictionary<int,List<(int,int)>> graph = new Dictionary<int,List<(int,int)>>();
        int[] paths = new int[n];
        for(int i = 0; i < n; i++) {paths[i] = Int32.MaxValue;}
        paths[src] = 0;
        for (int i = 0; i <= K; i++) {
            int[] p = new int[n];
            Array.Copy(paths,p,n);
            foreach (int[] e in flights) {
                int orig = e[0], dest = e[1], price = e[2];
                p[dest] = paths[orig] == Int32.MaxValue? p[dest] : Math.Min(p[dest], paths[orig] + price);
            }
            paths = p;
        }
        return paths[dst] == Int32.MaxValue? -1 : paths[dst];
    }
}
