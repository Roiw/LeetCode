public class FreqStack {
    
    // Map Freq to List of Element Nodes..  (freq by val by index)
    private Dictionary<int, List<int>> _freqMap = new Dictionary<int, List<int>>();
    // Map element to Frequency
    private Dictionary<int, int> _elemsMap = new Dictionary<int, int>();
    // The biggest frequency we have..
    private int _biggestFrequency = 0; 
    
    public FreqStack() {
        _freqMap.Add(1, new List<int>());
    }
    
    public void Push(int x) {
        // Add to list to keep the push order..
        int freq = 0;
        
        // Add to the element map to keep track of the frequency of each element in O(1)
        if (_elemsMap.ContainsKey(x)) {
            
            // Add to the frequency map, together with the elements of its frequency..
            freq = _elemsMap[x];
            //_freqMap[freq].Remove(x);
            if (!_freqMap.ContainsKey(freq+1))
                _freqMap.Add(freq+1, new List<int>());

            _freqMap[freq+1].Add(x);
            _elemsMap[x] = freq + 1;
        } else {
            _elemsMap.Add(x, 1); // don't exist on map, added as frequency 1..
            _freqMap[1].Add(x); // added on the frequency 1 layer..
        }
        _biggestFrequency = (freq + 1) > _biggestFrequency ? freq + 1: _biggestFrequency;
    }
    
    public int Pop() {
        List<int> mostFrequents = _freqMap[_biggestFrequency];
        int x = mostFrequents[mostFrequents.Count -1 ];     
        
        // Remove from frequency map..
        _freqMap[_biggestFrequency].RemoveAt(mostFrequents.Count-1);

        // Remove from elem map..
        if (_elemsMap[x] == 1)
            _elemsMap.Remove(x);
        else 
            _elemsMap[x] = _elemsMap[x] - 1;
       
        _biggestFrequency = (_freqMap[_biggestFrequency].Count == 0)? _biggestFrequency - 1: _biggestFrequency;    
        return x;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 */