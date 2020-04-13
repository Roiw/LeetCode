public class Solution {
    public bool IsAnagram(string s, string t) {
        
        if (s.Length != t.Length)
            return false;
        
        Dictionary<char,int> m = new Dictionary<char,int>();
        
        for (int i = 0; i < s.Length; i++){
            
            if (m.ContainsKey(s[i])){
                m[s[i]]++;
            }else 
                m.Add(s[i], 1);
            
            if (m.ContainsKey(t[i])){
                m[t[i]]--;
            }else 
                m.Add(t[i], -1);
        }
        
        foreach(KeyValuePair<char,int> kvp in m){
            if (kvp.Value != 0)
                return false;
        }
        
        return true;
    }
}
