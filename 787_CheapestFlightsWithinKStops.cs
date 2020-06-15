// WORK IN PROGRESS!!
public class Solution {
    private Dictionary<int,List<(int,int)>> _graph;
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int K) {
        _graph = new Dictionary<int,List<(int,int)>>();
        foreach (int[] e in flights){
            _graph.TryAdd(e[0], new List<(int,int)>(){(Int32.MinValue,0)});
            _graph[e[0]].Add((e[1],e[2]));
        }
        return Navigate(src, dst, K-1, 0);
    }
    
    private int Navigate (int current, int dst, int K, int price) {
        if (K < -1 || !_graph.ContainsKey(current))
            return -1;
        
        int minPrice = price;
        bool found = false;
        for (int i = 1; i < _graph[current].Count; i++){
            (int n , int p) = _graph[current][i];
            if (n == dst){
                minPrice = minPrice == price? price+p : Math.Min(minPrice, price + p);
                found = true;
            }
            else {
                if (!_graph.ContainsKey(n)) continue;
                (int nextPrice, int arrived) = _graph[n][0];
                if (nextPrice == -1) continue;
                else if (nextPrice > 0 && arrived < minPrice + p)
                    minPrice = minPrice == price? nextPrice + p : Math.Min(minPrice, nextPrice + p);
                else {
                    int aux = Navigate(n, dst, K-1, minPrice + p);
                    if (aux > 0){
                        minPrice = minPrice == price? aux : Math.Min(minPrice, aux);
                        found = true;
                    }
                }
            }
        }
        _graph[current][0] = !found? (-1,0) : (minPrice,price);
        return _graph[current][0].Item1;
    }
    
}
