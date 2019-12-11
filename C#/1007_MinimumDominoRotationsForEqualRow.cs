public class Solution {
    public int MinDominoRotations(int[] A, int[] B) {
        
        int numberFromAUp = CheckOneSide(A,B);
        int numberFromBUp = CheckOneSide(B,A);
        int ans = Math.Min(numberFromAUp, numberFromBUp);
        
        if (ans == int.MaxValue)
            return -1;
        else 
            return ans;
    }
    
    public int CheckOneSide(int[] C, int[] D) {
        int[] ans = new int[6];
        for (int i = 1; i < 7; i++) {
            int count = 0;
            for (int j = 0; j < C.Length; j++) {
                if (C[j] != i && D[j] != i){
                    count = int.MaxValue;
                    break;
                }
                if (C[j] == i)
                    continue;
                else
                    count++;
            }
            ans[i-1] = count;
        }
        // Check min number
        int min = int.MaxValue;
        for(int h = 0; h < 6; h++){
            if (ans[h] < min)
                min = ans[h];
        }
        return min;
    }
}