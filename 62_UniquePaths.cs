public class Solution {
    int[,] _mem;
    public int UniquePaths(int m, int n) {
        _mem = new int[m,n];
        _mem[m-1,n-1] = 1; // Target..
        return DFS(m, n, 0, 0);
    }
    
    private int DFS(int m, int n, int cM, int cN) {
        if ( _mem[cM,cN] > 0) 
            return _mem[cM,cN];
        
        int right = 0, down = 0;
        if (cM < m - 1) right = DFS(m, n, cM + 1, cN);
        if (cN < n - 1) down = DFS(m, n, cM, cN + 1);
        
        _mem[cM,cN] = right + down;
        return _mem[cM,cN];
    }
}
