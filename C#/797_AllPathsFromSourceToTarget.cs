public class Solution {
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        return Find(graph, new List<IList<int>>(), new List<int> {0}, 0);
    }
    
    public IList<IList<int>> Find(int[][] graph, IList<IList<int>> rst, List<int> curr, int index ) {
        foreach(int e in graph[index]) {
            List<int> aux = new List<int>(curr);
            aux.Add(e);
            if (e == graph.Length - 1) rst.Add(aux);
            else rst = Find(graph, rst, aux, e);
        }
        return rst;
    }
}
