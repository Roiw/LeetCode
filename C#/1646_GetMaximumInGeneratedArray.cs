/*

    The Plan:
        - calculate every element.
        - Keep track of the biggest

*/

public class Solution {
    public int GetMaximumGenerated(int n) {
        if (n == 0) return 0;
        if (n == 1) return 1;
        
        int[] arr = new int[n + 1];
        arr[0] = 0; arr[1] = 1;
        int max = 1;
        
        for (int i = 1; i < n; i++){
            int pos = 2 * i;
            bool condition1 = pos >= 2 && pos <= n;
            bool condition2 = pos + 1 >= 2 && pos + 1 <= n;
            if (condition1) {
                arr[pos] = arr[i];
                max = Math.Max(max, arr[pos]);
            }
                
            if (condition2) {
                arr[pos + 1] = arr[i] + arr[i + 1];
                max = Math.Max(max, arr[pos + 1]);
            }
                
            if (!condition1 && !condition2)
                break;
        }
        
        return max;
    }
}
