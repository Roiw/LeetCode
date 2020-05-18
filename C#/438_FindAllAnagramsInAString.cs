public class Solution {
    
    // Word as dictionary
    private Dictionary<char, int> _ps = new Dictionary<char,int>(); 
    // My buffer..
    private Dictionary<char, int> _buffer = new Dictionary<char,int>();
    // Reference
    private Dictionary<char, int> _reference = new Dictionary<char,int>();
    
    // Process new element O(1)
    private void AddToWindow(char c){
        if (!_ps.ContainsKey(c)) {
            if (!_buffer.TryAdd(c,1)) _buffer[c]++;
        }         
        else if (_reference[c] == 0)
            _buffer.Add(c,1);
        else
            _reference[c]--;
    }
    // Element leaving the window O(1)
    private void LeaveWindow(char c){
        
        // Remove from buffer..
        if (_buffer.ContainsKey(c)){
                if (_buffer[c] == 1) 
                    _buffer.Remove(c);
                else
                    _buffer[c]--;
        }
        else if (_reference.ContainsKey(c))
            _reference[c]++;
    }
    
    public IList<int> FindAnagrams(string s, string p) {
        List<int> ans = new List<int>();
        if (s.Length == 0 || s.Length < p.Length) return ans;
        
        // Initialize word as dictionary..
        foreach (char c in p) {
            if (!_ps.TryAdd(c, 1))
                _ps[c]+=1;
        }           
        
        // Reference to original Dictionary..
       _reference = new Dictionary<char,int>(_ps);    
        
        // Initial buffer..
        _buffer = new Dictionary<char,int>();    
        
        for (int i = 0; i < p.Length; i++) {
            AddToWindow(s[i]);            
        }
        
        if (_buffer.Count == 0)
            ans.Add(0);

        for(int i = p.Length; i < s.Length; i++){       
            char c = s[i]; // New Guy
            char o = s[i-p.Length]; // Leaving the window.
            
            LeaveWindow(o); 
            AddToWindow(c);
            
            if (_buffer.Count == 0)
                ans.Add(i - p.Length + 1);
                    
        }
        return ans;
    }
}
