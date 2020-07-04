public class Solution {
    public int[] PrisonAfterNDays(int[] cells, int N) {
        
        int[] aux = new int[cells.Length];
        
        // It repeats every 14 days..
        N = N % 14 == 0 ? 14 : N % 14;
        
        for (int n = 0; n < N; n++) {
            for (int i = 1; i < cells.Length - 1; i++){
                aux[i] = cells[i-1] == cells[i+1]? 1 : 0;   
            }
            Array.Copy(aux, cells, 8);
        }
        
        return cells;        
    }
}
