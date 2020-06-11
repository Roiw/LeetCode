public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (t.Length < s.Length || s == null || t == null) return false;
        if (s.Length == 0) return true;
        int aux = 0;
        for (int i = 0; i < t.Length; i++){
            if (s[aux] == t[i]) aux++;
            if (aux == s.Length) return true;
        }      
        return false;
    }
}