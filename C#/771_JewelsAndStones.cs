public class Solution {
    public int NumJewelsInStones(string J, string S) {
        HashSet<char> jewels = new HashSet<char>();
        int ans = 0;
        // Prep
        foreach (char c in J) {
            jewels.Add(c);
        }
        
        foreach (char c in S) {
            if (jewels.Contains(c))
                ans++;
        }
        
        return ans;
    }
}