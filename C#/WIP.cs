public class Solution {
    
    // Check if partition 1 is bigger, smaller or equal than partition 0.
    private int CheckPartitions(int[] A, (int,int)partition0, (int,int) partition1) {
        (int startP0, int endP0) = partition0;
        (int startP1, int endP1) = partition1;
        
        int i = startP0, j = startP1;
        int ans = 0;
        while (i >= endP0 && j >= endP1) {
            ans = (A[i] < A[j])? 1: A[i] == A[j]? ans: -1;
            i--; j--;
        }
        // Remaining on partition 0..
        while (i >= endP0){
            if (A[i] != 0) return -1;
            i--;
        }
        // Remaining on partition 1..
        while (j >= endP1){
            if (A[j] != 0) return 1;
            j--;
        }
        
        return ans;
    } 
    
    // Roll down on the tree.
    private int[] Tree(int[] A, int p0, int p1) {
        
        (int,int) rangePartition0 = (p0, 0);
        (int,int) rangePartition1 = (p1 - 1, p0 + 1);
        (int,int) rangePartition2 = (A.Length - 1, p1);
        
        int cond1 = CheckPartitions(A, rangePartition0, rangePartition1);
        int cond2 = CheckPartitions(A, rangePartition1, rangePartition2);
        
    
        // Base case..
        if (cond1 == 0 && cond2 == 0)
            return new int[]{p0,p1};
       
        // Can move p0?
        if (p0 < p1 - 2 && cond1 == 1){
            int[] ans = Tree(A, p0 + 1, p1);
            if (ans != null) return ans;
        }
        
        // Can move p1?
        if (p1 < A.Length - 1 && cond2 == 1) {
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


// # Approach 2.

public class Solution {

    // Key Ideas: 
    // All partitions must have the same number of 1's
    // The number of 1's must be multiple of 3 (we have 3 partitions).
    
    public int[] ThreeEqualParts(int[] A) {
        
        // Total number of 1's in the array.
        int totalOnes = 0;
        for (int i = 0; i < A.Length; i++)
            totalOnes = A[i] == 1? totalOnes + 1: totalOnes;
        
        // Check if the array is valid.
        if (totalOnes % 3 != 0) return new int[] { -1, -1 };
        
        // Amount of 1's per partition.
        int onesPerPartition = totalOnes / 3; 
        
        // Finding P1: the first 'onesPerPartition' ones from right..
        int start = A.Length - 1, ones = 0;
        while (ones <= onesPerPartition) {
            if (A[start] == 1) ones++;
            if (ones <= onesPerPartition) start--;
        }
        
        int p1 = start + 1; // Found p1.
        
        // Verify next partition starting at p1.. (finds p0..)
        int j = A.Length-1;
        ones = 0; 
        while (ones <= onesPerPartition) {
            if (A[start] != A[j]) return new int[] { -1, -1 };
            if (A[start] == 1) ones++;
            if (ones <= onesPerPartition) start--;
            j--;
        }
        
        int p0 = start; // Adjust p0
        
        // Verify next partition starting from possible p0..
        ones = 0; j = A.Length-1;
        while (ones != onesPerPartition) {
            if (A[start] != A[j]) return new int[] { -1, -1 };
            if (A[start] == 1) ones++;
            if (ones <= onesPerPartition) start--;
            j--;
        }
    
    
        return new int[] { p0, p1 } ;
    }
}