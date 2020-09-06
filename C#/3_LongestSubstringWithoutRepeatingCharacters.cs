public class Solution {
    /*
    
    Brute force solution. O(N²)
        starting from each character keep track of repetitions using a HashSet
        
    Two Pointer Solution O(N)
        Start both pointers on index i = 0.
        Loop:
        Move p1 to index i + 1. 
            Add p1 element to a hashset. 
                If okay, increase the size of the max substring.
                If not okay, move p0 to the right and remove it from hashset. decrese the size of max substring.
                Repeat until I can add p1.
        
    
    "abcabcbb"
    p0:     0,  0   0   1   2   3   5      
    p1:     0,  1   2   3   4   5   6      
    max:    1,  2   3   3   3   3   2   
    Hash:   a,  ab  abc bca cab abc cb
    
    
    "bbb"
    p0:     0,  1,  1,    
    p1:     0,  1,  1,
    max:    1,  1,  1,
    Hash:   b,  b,  b,
    
    "pwwkew"
    p0:     0,  0,  2,  2,  2   5
    p1:     0,  1,  2,  3,  4,  5
    max:    1,  2,  1,  2,  3   1
    Hash:   p,  pw, w,  wk, wke,w
    
    
    */
    public int LengthOfLongestSubstring(string s) {
        // 15
        
        if (s == "") return 0;
        
        int p0 = 0, max = 1;
        HashSet<char> inSubstring = new HashSet<char>(){s[0]};
        
        for (int i = 1; i < s.Length; i++) {
            if (inSubstring.Add(s[i])) {
                // char not on substring..
                max = max < inSubstring.Count? inSubstring.Count : max;
            }
            else {
                // char not on substring..
                do {
                    inSubstring.Remove(s[p0]);
                    p0++;
                } while (!inSubstring.Add(s[i]));
            }
        }
        return max;  
    }
}