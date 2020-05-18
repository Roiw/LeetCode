public class Solution {
    public int[][] IntervalIntersection(int[][] A, int[][] B) {
        
        int a = 0;
        int b = 0;
        List<int[]> ans = new List<int[]>();
        
        while (a < A.Length && b < B.Length) {
            int i = 0;
            int j = 0;
            // Case exact start
            if (A[a][0] == B[b][0]){
                i = A[a][0];
                j = 0;
                if (A[a][1] > B[b][1]){
                    j = B[b][1];
                    b++;
                    ans.Add(new int[] {i,j});
                }
                else {
                    j = A[a][1];
                    a++;
                    ans.Add(new int[] {i,j});
                }
            }
            // Case A start..
            else if (A[a][0] > B[b][0]){
                i = A[a][0];
                if (A[a][0] < B[b][1]) {
                    if (A[a][1] < B[b][1]){
                        j = A[a][1];
                        a++;
                    } else if (A[a][1] > B[b][1]){
                        j = B[b][1];
                        b++;
                    } 
                    else {
                        j = A[a][1];
                        a++;
                        b++;
                    }
                    ans.Add(new int[] {i,j});
                }
                else if (A[a][0] == B[b][1]){
                    ans.Add(new int[] {i,i});
                    b++;
                } else
                    b++;
            }
            // Case B start..
            else if (B[b][0] > A[a][0]){
                i = B[b][0];          
                if (B[b][0] < A[a][1]){
                    if (B[b][1] < A[a][1]){
                        j =  B[b][1];
                        b++;
                    } else if (B[b][1] > A[a][1]) {
                        j = A[a][1];
                        a++;
                    }
                    else {
                        j = B[b][1];
                        a++;
                        b++;
                    }
                    ans.Add(new int[] {i,j});
                }
                else if (B[b][0] == A[a][1]) {
                    ans.Add(new int[] {i,i});
                    a++;
                }else 
                    a++;
            }
        }
        return ans.ToArray();
    }
}
