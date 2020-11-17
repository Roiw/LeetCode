/*

    The Plan:
        - We are looking for an O(N) solution given the input constraint.
        - Count characters O(N). Dictionary<char, int>
        - Transform the dictionary so we have occourcences by char. O(1) we only have a few letters.
        - Foreach occorrence with char-list bigger than 1 remove a char until we remove all chars or have unique frequency.
*/

public class Solution {
    public int MinDeletions(string s) {
        
        Dictionary<char, int> counter = new Dictionary<char,int>();
        Dictionary<int, int> amountFreqs = new Dictionary<int, int>();
        
        // O(N)
        foreach (char c in s){
            if (!counter.TryAdd(c,1))
                counter[c]++;
        }
        
        // Transform O(1)
        foreach (var kvp in counter){
            amountFreqs.TryAdd(kvp.Value, 0);
            amountFreqs[kvp.Value]++;
        }
        
        // Fix freqs O(1)
        HashSet<int> freqs = new HashSet<int>(amountFreqs.Keys);
        
        int totalDeletions = 0;
        foreach (var kvp in amountFreqs){
            if (kvp.Value == 1)
                continue;
            
            int occur = kvp.Key;
            int totalFreqs = kvp.Value;
            
            while (totalFreqs > 1) {
                occur--;
                totalDeletions++;
                if (occur == 0){
                    totalFreqs--;
                    occur = kvp.Key;
                }    
                else if (!freqs.Contains(occur)) {
                    freqs.Add(occur);
                    occur = kvp.Key;
                    totalFreqs--;
                }                
            }            
        }
        return totalDeletions;
    }
}
