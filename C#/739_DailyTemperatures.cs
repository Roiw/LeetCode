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


/*
    47

    Using Stacks (newer version)
    
        - Go through temp array:
            whenever next temperute is higher than previous, 
            unstack until new value is lower or equal. For every unstack add number of days to answer array.    
        
        50
        
        
        [73, 74, 75, 71, 69, 72, 76, 73]
        
        73  74  75  71  69  72  76  73  
        1   1   0   2   1   1   0   0
        
    59
*/


public class Solution {
    public int[] DailyTemperatures(int[] T) {
        int[] answer = new int[T.Length];
        Stack<(int temp, int index)> memo = new Stack<(int,int)>();
        memo.Push((T[0], 0));
        for (int i = 1; i < T.Length; i++) {
            while(memo.Count > 0 && memo.Peek().temp < T[i]) {
                (int temp, int index) = memo.Pop();
                answer[index] = i - index;
            }
            memo.Push((T[i], i));
        }
        return answer;
    }
}