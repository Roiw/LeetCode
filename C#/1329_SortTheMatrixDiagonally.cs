public class Solution {
    public int[][] DiagonalSort(int[][] mat) {
        // Make arrays..
        // Sort each array..
        // Write at matrix..
        
        List<List<int>> arrays = new List<List<int>>();
        
        
        int aIndex = 0;
        arrays.Add(new List<int>());
        // Header..
        for (int j = 0; j < mat[0].Length; j++){
            int k = 0;
            int l = j;

            while (k <= mat.Length-1 && l <= mat[k].Length-1 ){
                arrays[aIndex].Add(mat[k][l]);
                k++;
                l++;
            }
            arrays.Add(new List<int>());
            aIndex++;
        }    
        
        // Rest..
        for (int i = 1; i < mat.Length; i++){
            int k  = i;
            int l = 0;

            while (k <= mat.Length-1 && l <= mat[k].Length-1 ){
                arrays[aIndex].Add(mat[k][l]);
                k++;
                l++;
            }
            arrays.Add(new List<int>());
            aIndex++;
        }
        
        // Sorting..
        for (int n = 0; n < arrays.Count; n++){
            arrays[n].Sort();
        }
        
        // Rewritting on the matrix..
        aIndex = 0;
        // Header..
        for (int j = 0; j < mat[0].Length; j++){
            int k = 0;
            int l = j;

            while (k <= mat.Length - 1 && l <= mat[k].Length - 1 ){
                mat[k][l] = arrays[aIndex][k];
                k++;
                l++;
            }
            aIndex++;
        }    
        
        // Rest..
        for (int i = 1; i < mat.Length; i++){
            int k  = i;
            int l = 0;

            while (k <= mat.Length-1 && l <= mat[k].Length-1 ){
                mat[k][l] = arrays[aIndex][l];
                k++;
                l++;
            }
            aIndex++;
        }
        
        return mat;
    }
}
