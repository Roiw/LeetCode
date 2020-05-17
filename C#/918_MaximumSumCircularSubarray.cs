public class Solution {   
	
    public int MaxSubarraySumCircular(int[] A) {
        if (A.Length == 1) return A[0]; // Obviously
        
        // Case 1: Ans = Kadane(Max) --> Case inline
        // Case 2: Ans = Sum - Kadane(Min) --> Case loop around
        // Case 3: Ans = Kadane(Max) --> Case Sum == min; all elements are negative.
        
        int max = A[0], min = A[0], sum = A[0];        
        int lMax = A[0], lMin = A[0];
        
        for (int i = 1; i < A.Length; i++){
            sum += A[i] ;
            lMax = Math.Max(lMax, 0) + A[i];
            lMin = Math.Min(lMin, 0) + A[i];
            max = Math.Max(max, lMax);
            min = Math.Min(min, lMin);
        }
        // Case 3
        if (sum == min)
            return max;
        
        return Math.Max(max, sum - min);   
    }
}
