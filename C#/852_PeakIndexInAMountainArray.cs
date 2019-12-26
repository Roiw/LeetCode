public class Solution {
    public int PeakIndexInMountainArray(int[] A) {
        return FindPeak(A, 0, A.Length-1);
    }
    
    public int FindPeak(int[] A, int start, int end) {
    
        int mid = start + ((end + 1) - start)/2;
        
        // Base case 1
        if (mid == start || mid == end) {
            if (A[start] > A[start+1])
                return start;
            if (A[end] > A[end-1])
                return end;
        }
        
        // Base case 2
        if (A[mid] > A[mid+1] && A[mid] > A[mid-1])
            return mid;
        
        if (A[mid +1] > A[mid])
            return FindPeak( A, mid+1, end);
        else
            return FindPeak(A, 0, mid -1);
    }
}
