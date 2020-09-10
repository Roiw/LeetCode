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


public class Solution {
    /*
        - Two pointer solution (Sliding window) -  Using dictionary.
            p0 = 0, p1 = 0
            Dictionary<char, int> Containing every element of substring 1
            
            if s1 is bigger than s2 return false (pre-check)
            
            remove p1 from dictionary
            
            Move while p1 != s2.Length:
                remove p1 from the dictionary and move p1.
                if (p1-p0 < s1.Length) continue;
                Add p0 to the Dictionary, move p0
                check if dictionary is empty; if true we found a match and can return
    
    */
    
    public bool CheckInclusion(string s1, string s2) {
        
        // If s1 is smaller then we must return.
        if (s1.Length > s2.Length) return false;
        
        // Dictionary with all chars in S1.
        Dictionary<char,int> S1 = new Dictionary<char, int>();
        foreach (char c in s1) {
            if (!S1.TryAdd(c, 1))
                S1[c]+=1;
        }
        
        // Chars that I can add back to S1 dictionary
        HashSet<char> validChars = new HashSet<char>(S1.Keys);
        
        int p0 = 0;
        
        for (int i = 0; i < s2.Length; i++) {
            
            char rightChar = s2[i];
            char leftChar = s2[p0];
            
            // Found a match!
            if (S1.Count == 0) return true;
            
            // Remove the right char from the window, if valid.
            if (validChars.Contains(rightChar)) 
                RemoveChar(S1, rightChar);
             
            // True if we are checking a full s1 string 
            if (i - p0 < s1.Length )
                continue;
            
            // Add the left character to the window, if valid.
            if (validChars.Contains(leftChar))
                AddChar(S1, leftChar);
                
            p0++; // Advance p0.
        }
        
        // Found a match!
        if (S1.Count == 0) return true;
        
        return false;
    }
    
    // Helper: Add to the Window
    private void AddChar(Dictionary<char,int> dict, char c) {
        if (!dict.TryAdd(c, 1)){
            dict[c]++;
            if (dict[c] == 0) 
                dict.Remove(c);
        }
    }
    
    // Helper: Remove an element from the Window.
    private void RemoveChar(Dictionary<char,int> dict, char c) {
        if (dict.ContainsKey(c)){
            dict[c]--;
            if (dict[c] == 0)
                dict.Remove(c);
        }
        else
            dict.Add(c, -1);
    }
}