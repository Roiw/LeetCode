/*

    The plan:
        - Backtrack O(e^N)
        - At each node we can call Left and Right
            L(N) and R(N - i) the result is L * R
            This represent the number of possibilities on each branch.
            Notice that if one of the sides has the answer of 0 don't multiply it, we disconsider.
        - You can memoize to improve performance at the cost o memory.
        
    0 -> 0
    1 -> 1
    2 -> 2 (it could be on the left or right)
    
    1
    L(2) R(0) -> 2
    L(1) R(1) -> 1 * 1 = 1
    L(0) R(2) -> 2

*/

public class Solution {
    public int NumTrees(int n) {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        if (n == 2)
            return 2;
        
        int total = 0;
        for (int i = 0; i < n; i++) {
            
            int left = Math.Max(1, NumTrees(i));
            int right = Math.Max(1, NumTrees(n - i - 1)); // -1 because we must count the current vertice.
            total += left * right;
        }
        return total;
    }
}
