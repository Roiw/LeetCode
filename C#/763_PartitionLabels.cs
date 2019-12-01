public class Solution {
    public IList<int> PartitionLabels(string S) {
        
        Dictionary<char, int> occ = new Dictionary<char, int>();
        HashSet<char> search = new HashSet<char>();
        List<int> ans = new List<int>();
        
        // Find occurences..
        foreach (char c in S) {
            if (occ.ContainsKey(c)) {
                occ[c]++;
            } else {
                occ.Add(c, 1);
            }
        }
        
        int pSize = 0;
        
        // Create partitions..
        foreach (char c in S) {
            pSize++;
            search.Add(c);
            occ[c]--;
            if (occ[c] == 0) {
                search.Remove(c);
                if (search.Count == 0) {
                    // found an partition..
                    ans.Add(pSize);
                    pSize = 0;                
                }
            }      
        }        
        
        return ans;
    }
}
