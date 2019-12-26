public class Solution {
    public int[] SortedSquares(int[] A) {
        Stack<int> negatives = new Stack<int>();
        int[] ans = new int[A.Length];
        int ansIndex = 0;
        
        for(int i = 0; i < A.Length; i++) {
            int sqrd = A[i] * A[i];
            
            if ( A[i] < 0 )
                negatives.Push(sqrd);
            
            else {
                while (negatives.Count > 0 && sqrd > negatives.Peek()) {
                    if  (sqrd > negatives.Peek()) {
                        ans[ansIndex] = negatives.Pop();
                        ansIndex++;
                    }
                }
                ans[ansIndex] = sqrd;
                ansIndex++;
            }
        }
        
        // Add remaining stack elements..
        while(negatives.Count > 0) {
            ans[ansIndex] = negatives.Pop();
            ansIndex++;
        }
        
        return ans;
    }
}