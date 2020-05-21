public class RandomizedSet {

    private Dictionary<int,int> _data;
    private List<int> _support;
    
    /** Initialize your data structure here. */
    public RandomizedSet() {
        _data = new Dictionary<int,int>();
        _support = new List<int>();        
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if (_data.TryAdd(val, _support.Count)){
            _support.Add(val);
            return true;
        }
        return false;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if (!_data.ContainsKey(val)) return false;
        int i = _data[val], lastIndex = _support.Count-1;
        if (lastIndex != i) {         
            _support[i] = _support[lastIndex];
            _support.RemoveAt(lastIndex);
            _data[_support[i]] = i;
        }
        else
            _support.RemoveAt(lastIndex); // Case only one element.
        
        return _data.Remove(val);
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        Random r = new Random();
        int rInt = r.Next(0, _support.Count); 
        return _support[rInt];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
 