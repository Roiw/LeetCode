public class Solution {
    public int[][] FlipAndInvertImage(int[][] A) 
    {
        for (int i =0; i < A.Length; i++)
        {
            if (A[i].Length == 1)
            {
                A[i][0] = A[i][0] == 1? 0 : 1;
               continue; 
            }
                           
            for (int j = 0; j < A[i].Length/2; j++)
            {        
                // Reverse
                int aux = A[i][j];
                A[i][j] = A[i][A[i].Length - 1 - j];
                A[i][A[i].Length - 1 - j] = aux;
                
                // Invert
                A[i][A[i].Length - 1 - j] = A[i][A[i].Length - 1 - j] == 1? 0 : 1;
                A[i][j] = A[i][j] == 1? 0 : 1;
            }
            if (A[i].Length % 2 != 0)
            {
                 A[i][A[i].Length/2] = A[i][A[i].Length/2] == 1? 0 : 1;
            }
        }
        return A;
    }
}
