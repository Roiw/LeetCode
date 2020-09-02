public class Solution {
    // 23
    /*
        Think of this as a DECISION TREE
        
        [ _ , _ , _ ]
         ^   ^
         
         1 - Move p1 right
         1 - Move p0 right   Can have up to two children :-)
         
         [ p0, p1, _ ]
         [ p0, ]
        
    */
    
    private bool CheckValid(int[] A, int p0, int p1) {
        bool cond1 = true, cond2 = true, cond3 = true;

        int i = 0, j = p0 + 1;
        while (i <= p0 && j < p1) {
            if (A[i] == 0){
                i++; continue;
            }
            if (A[j] == 0){
                j++; continue;
            }
            if (A[i] != A[j]) {
                cond1 = false; break;
            }
            i++; j++;
        }
        
        i = p0 + 1; j = p1;
        while (i < p1 && j < A.Length) {
            if (A[i] == 0){
                i++; continue;
            }
            if (A[j] == 0){
                j++; continue;
            }
            if (A[i] != A[j]) {
                cond2 = false; break;
            }
            i++; j++;
        }
        
        i = 0; j = p1;
        while (i <= p0 && j < A.Length) {
            if (A[i] == 0){
                i++; continue;
            }
            if (A[j] == 0){
                j++; continue;
            }
            if (A[i] != A[j]) {
                cond3 = false; break;
            }
            i++; j++;
        }
        
        return cond1 && cond2 && cond3;
    }
    
    // Check if partition configuration is valid.
    private (int, int, int) GetPartitions(int[] A, int p0, int p1) {
        double num1 = 0, num2 = 0, num3 = 0;
        // num 1 
        for (int i = 0; i <= p0; i++){
            num1 += (Math.Pow(2, (double)(p0 - i)) * A[i]);
        }
        // num 2
        for (int i = p0 + 1; i < p1; i++){
            num2 += (Math.Pow(2, (double) ((p1 - 1) - i) ) * A[i]);
        }
        // num 3
        for (int i = p1; i < A.Length; i++){
            num3 += (Math.Pow(2, (double)((A.Length - 1) - i) ) * A[i]);
        }
        return ((int)num1, (int)num2, (int)num3);
    }
    
    // Roll down on the tree.
    private int[] Tree(int[] A, int p0, int p1) {
        
        // Base case..
        if (CheckValid(A, p0, p1))
            return new int[]{p0,p1};
        
       
        // Can move p0?
        if (p0 < p1 - 2 ){
            int[] ans = Tree(A, p0 + 1, p1);
            if (ans != null) return ans;
        }
        
        // Can move p1?
        if (p1 < A.Length - 1) {
            int[] ans = Tree(A, p0, p1 + 1);
            if (ans != null) return ans;
        }
        
        return null;
    }
    
    public int[] ThreeEqualParts(int[] A) {
        int[] ans = Tree(A, 0, 2);
        
        return ans == null? new int[]{-1,-1}: ans;
    }
}