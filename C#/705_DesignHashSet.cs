public class MyHashSet {

    private bool[] _table;
    /** Initialize your data structure here. */
    public MyHashSet() {
        _table = new bool[1000000];
    }
    
    public void Add(int key) {
        _table[key] = true;
    }
    
    public void Remove(int key) {
        _table[key] = false;
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        return _table[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
 