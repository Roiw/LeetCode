public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        List<IList<int>> ans = new List<IList<int>>(); 
        if (numRows == 0 ) return ans;
        ans.Add(new List<int>{1}); 
        if (numRows == 1) return ans;
        ans.Add(new List<int>{1,1}); 
        if (numRows == 2) return ans;
        
        for (int i = 2; i < numRows; i++) {
            ans.Add(new List<int>{1});
            for (int j = 0; j <  ans[ans.Count-2].Count-1; j++){
                ans[i].Add(ans[i-1][j] + ans[i-1][j+1]);
            }
            ans[i].Add(1);
        }
        return ans;
    }
}
