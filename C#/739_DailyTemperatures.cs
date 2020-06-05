public class Solution {
    // 40
    public int[] DailyTemperatures(int[] T) {
        Stack<(int,int)> dt = new Stack<(int,int)>();
        int[] ans = new int[T.Length];
        for (int i = T.Length-1; i >= 0; i--){         
            int count = 0;
            while(dt.Count > 0) {
                (int temp, int d) = dt.Pop();
                count += d;
                if (temp > T[i]){
                    ans[i] = count;
                    dt.Push((temp,count));
                    dt.Push((T[i], 1));
                    break;
                }              
            }
            if (dt.Count == 0){
                dt.Push((T[i],1));
                ans[i] = 0;
            }
        }
        return ans;
    }
}
