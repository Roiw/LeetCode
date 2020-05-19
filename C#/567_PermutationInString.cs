public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s2.Length < s1.Length) return false;
        
        // a == 97, z == 122
        char[] perm = new char[26];
        char[] buffer = new char[26];
        int count = 0;
        
        foreach (char c in s1){ perm[c - 97]++; }       
        
        // O(N)
        for (int i = 0; i < s2.Length; i++){         
            int e = s2[i] - 97;
            int lIndex = i - s1.Length;
            
            if (i >= s1.Length) {
                int charIndex = s2[lIndex] - 97;           
                if (buffer[charIndex] > 0){
                    buffer[charIndex]--;
                    if (buffer[charIndex] < perm[charIndex])
                        count--;
                }                 
            }
            if (perm[e] > 0) {
                if (buffer[e] < perm[e])
                    count++;
                buffer[e]++;
            }           
            if (count == s1.Length)
                return true;       
        }
        return false;
    }
}
