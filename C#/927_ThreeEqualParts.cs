public class Solution {

    // Key Ideas: 
    // All partitions must have the same number of 1's
    // The number of 1's must be multiple of 3 (we have 3 partitions).
    
    public int[] ThreeEqualParts(int[] A) {
        
        // Total number of 1's in the array.
        int totalOnes = 0;
        for (int k = 0; k < A.Length; k++)
            totalOnes += A[k];
        
        // Edge case.
        if (totalOnes == 0) return new int[] {0, A.Length - 1};
        
        // Check if the array is valid.
        if (totalOnes % 3 != 0 ) return new int[] { -1, -1 };
        
        // Amount of 1's per partition.
        int onesPerPartition = totalOnes / 3; 
        
        
        // Find number from right to left.
        int start = A.Length - 1, ones = 0;
        while (start > 0) {
            if (A[start] == 1) ones++;
            if (ones == onesPerPartition) break;
            start--;
        }
        
        // Find number from left to right.
        int i  = Compare(0, start, A);
        i--; // At the end i is one unit ahead.
        
        // Check middle.
        int j = Compare(i + 1, start, A);
        
        return (i == -1 || j == -1) ? new int[] {-1,-1} : new int[] { i, j } ;
    }
    
    // Compare two 'numbers' where p1 ends at Arr.Length. 
    // Return the position after the last or -1.
    private int Compare(int p0, int p1, int[] A){
        if (p0 < 0) return -1;
        bool hasBegan = false;
        while(p1 <= A.Length -1 && p0 < A.Length) {
            if (hasBegan && A[p0] != A[p1]) return -1;
            if (hasBegan && A[p0] == A[p1]) p1++;
            if (!hasBegan && A[p0] != 0) { hasBegan = true; continue; }
            p0++;
        }
        return p0;
    }
}