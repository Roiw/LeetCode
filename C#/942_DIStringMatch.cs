public class Solution {
    public int[] DiStringMatch(string S) {
        
        List<int> arr = new List<int>();
        HashSet<int> added = new HashSet<int>();
        
        int downs = 0;
        for (int i = 0; i < S.Length; i++) {
            if (S[i] == 'D') downs++;
        }
        
        int curr = downs;
        arr.Add(curr); added.Add(curr);
        
        for (int i = 0; i < S.Length; i++) {
            if (S[i] == 'I') {
                curr = FindNextBigger(curr, added, S.Length);
                arr.Add(curr);
            } else {
                curr = FindNextSmaller(curr, added);
                arr.Add(curr);
            }
        }
        return arr.ToArray();     
    }
    
    private int FindNextBigger(int curr, HashSet<int> added, int len){
        for (int i = curr + 1; i <= len; i++){
            if (added.Add(i))
                return i;
        }
        return -100;
    }
    
    private int FindNextSmaller(int curr, HashSet<int> added){
        for (int i = curr-1; i >= 0; i--){
            if (added.Add(i))
                return i;
        }
        return -100;
    }
}
