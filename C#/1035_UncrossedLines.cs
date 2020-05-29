public class Solution {
    // 33 -> 57 (24min)
    public int MaxUncrossedLines(int[] A, int[] B) {
        int[][] aux = new int[A.Length+1][];
        aux[0] = new int[B.Length + 1];
        for (int i = 1; i < A.Length + 1; i++){
            aux[i] = new int[B.Length + 1];
            for (int j = 1; j < B.Length + 1; j++){
                if (A[i-1] == B[j-1])
                    aux[i][j] = aux[i-1][j-1] + 1;
                else
                    aux[i][j] = Math.Max(aux[i][j-1], aux[i-1][j]);
            }
        }
        return aux[A.Length][B.Length];
    }
}
