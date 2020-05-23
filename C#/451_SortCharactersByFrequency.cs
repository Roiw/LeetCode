public class Solution {
    public string FrequencySort(string s) {
        
        Dictionary<char, int> amounts = new Dictionary<char, int>();
        
        // Find amounts..
        foreach (char c in s) {
            if (!amounts.TryAdd(c, 1)) {amounts[c]++;}
        }
        
        var keys = amounts.Keys.OrderByDescending(x => amounts[x]);
        
        StringBuilder sb = new StringBuilder();
        
        foreach(var key in keys)
            sb.Append(key, amounts[key]); // Append any times a char..
        
        return sb.ToString();
    }
}
