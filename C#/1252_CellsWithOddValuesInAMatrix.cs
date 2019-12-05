public class Solution {
    public int OddCells(int n, int m, int[][] indices) {
        int odds = 0;
        int [,] arr = new int[n,m];
        foreach (int[] i in indices) {
            // Rows
            for (int col = 0; col < m; col++) {
                odds =  (arr[i[0], col] % 2 == 0)? odds+1: odds - 1;
                arr[i[0], col]++;
            }
            // Collumns
            for (int row  = 0; row < n; row++) {
                odds =  arr[row,i[1]] % 2 == 0? odds+1: odds - 1;
                arr[row,i[1]]++;
            }
        }
        return odds;
    }
}