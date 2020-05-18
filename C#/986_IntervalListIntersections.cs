public class Solution {
    public int[][] IntervalIntersection(int[][] A, int[][] B) {
        
        int a = 0;
        int b = 0;
        List<int[]> ans = new List<int[]>();
        
        while (a < A.Length && b < B.Length) {
            int i = 0;
            int j = 0;
            
            if (A[a][1] < B[b][0]) a++;
            else if (B[b][1] < A[a][0]) b++;
            else {
                i = Math.Max(A[a][0], B[b][0]);
                j = Math.Min(A[a][1], B[b][1]);
                ans.Add(new int[]{i,j});
                if (j == A[a][1]) a++;
                else
                    b++;
            }
        }
        return ans.ToArray();
    }
}
