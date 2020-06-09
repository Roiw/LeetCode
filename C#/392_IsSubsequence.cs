public class Solution {
    public bool IsSubsequence(string s, string t) {
        int [][] aux = new int[t.Length + 1][];
        aux[0] = new int[s.Length + 1];
        for (int i = 1; i < t.Length + 1; i++) {
            aux[i] = new int[s.Length + 1];
            for (int j = 1; j < s.Length + 1; j++) {
                aux[i][j] = (s[j-1] == t[i-1]) ? 
                    aux[i-1][j-1] + 1 : Math.Max(aux[i-1][j], aux[i][j-1]);
            }
        }
        if (aux[t.Length][s.Length] == s.Length) return true;
        else return false;
    }
}
