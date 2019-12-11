public class Solution {
    private int Target;
    private int[][] Graph;
    public IList<IList<int>> AllPathsSourceTarget(int[][] graph) {
        Target = graph.Length -1;
        Graph = graph;
        IList<IList<int>> rst = new List<IList<int>>();
        List<int> initial = new List<int> {0};
        rst = Find(rst, initial, 0);
        return rst;
    }
    
    public IList<IList<int>> Find(IList<IList<int>> rst, List<int> curr, int index ) {
        foreach(int e in Graph[index]) {
            List<int> aux = new List<int>(curr);
            if (e == Target) {
                aux.Add(e);
                rst.Add(aux);
            } else {
                aux.Add(e);
                rst = Find(rst, aux, e);
            }
        }
        return rst;
    }
}