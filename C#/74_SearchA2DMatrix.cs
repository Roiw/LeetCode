public class Solution {
    // Bin search on column..
    // Bin search on row..
    public bool SearchMatrix(int[][] matrix, int target) {
        if (matrix.Length == 0) return false;

        int ans = ColumnBS(matrix, target, 0, matrix.Length - 1 );
        if (ans < 0) {
            ans = ~ans;
            if (ans > matrix.Length) return false; // Element is bigger than all elements in matrix..
            if (ans == 0) return false;            // The element is smaller than all the elements in matrix..
            if (matrix[ans-1].Length == 0) return false;
            if (Array.BinarySearch(matrix[ans - 1], target) < 0) return false;
        }
        return true;
    }
    
    // Binary Search on Column.
    private int ColumnBS(int[][] m, int t, int i, int x) {
       
        // If end..
        if (i > x) return ~i;
        
        // Find mid..
        int mid = (x + i) / 2;
        
        if (m[mid].Length == 0) return ~0; // Special case: If we get an empty line in matrix.
        
        // If found
        if (m[mid][0] == t) return mid;
        
        // Bigger, go left..
        if (m[mid][0] > t) { return ColumnBS(m, t, i, mid - 1); }
        
        // Smaller, go right..
        else { return ColumnBS(m, t, mid + 1, x); }
    }
}
