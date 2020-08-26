public class Solution {
    private int DFS(int index, HashSet<int> onArr, int max) {
        
        int count = 0;      
        if (index  == max + 1)
            return 1;            
        
        for (int e =  1 ; e <= max; e++) { 
            if (onArr.Contains(e))
                continue;
            
            if (index % e != 0 && e % index != 0)
                continue;
            
            onArr.Add(e);
            count += DFS(index + 1,onArr, max);
            onArr.Remove(e);
        }
        
        return count;
        
    }
    public int CountArrangement(int N) {
        return DFS(1, new HashSet<int>(), N);
    }
}