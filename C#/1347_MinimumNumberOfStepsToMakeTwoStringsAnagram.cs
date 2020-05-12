public class Solution {
    public int MinSteps(string s, string t) {
        
        Dictionary<char,int> Ss = new Dictionary<char,int>();
        Dictionary<char,int> Ts = new Dictionary<char,int>();
        
        for(int i = 0; i < s.Length; i++){
            if (!Ss.TryAdd(s[i], 1))
                Ss[s[i]]++;
            if (!Ts.TryAdd(t[i], 1))
                Ts[t[i]]++;
        }
        
        int antiStep = 0; // Count what we don't need to change..
        foreach(KeyValuePair<char,int> kvp in Ss){
            if (Ts.ContainsKey(kvp.Key)){
                antiStep += Math.Min(Ts[kvp.Key], kvp.Value); // Gets the number that are equal.
            }
        }
        
        return s.Length - antiStep;
    }
}
