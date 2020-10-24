/*

    The plan:
    
    - Load all numbers in 2 dictionaries.
    - Count the amount each have.
    - Starting with the one with less candy see if each number could provide with an fair exchange. Using smallest first
*/

public class Solution {
    public int[] FairCandySwap(int[] A, int[] B) {
        HashSet<int> As = new HashSet<int>();
        HashSet<int> Bs = new HashSet<int>();
        
        int totalA = 0;
        int totalB = 0;
        
        for (int i = 0 ; i < A.Length ; i++) {
            As.Add(A[i]);
            totalA += A[i];
        }
        
        for (int i = 0 ; i < B.Length ; i++) {
            Bs.Add(B[i]);
            totalB += B[i];
        }
        
        int diff = Math.Abs(totalA - totalB);
        
        int[] it = totalA > totalB? B : A;
        HashSet<int> itSet = totalA > totalB? As : Bs;
        
        for (int i = 0; i < it.Length; i++) {
            int ans = (it[i] * 2 + diff) /2 ;
            
            if ( itSet.Contains( ans ) ) 
                return totalA > totalB? new int[] { ans, it[i] } : new int[] { it[i], ans }; 
        }
        
        
        return new int[] {-1,-1};
    }
}
