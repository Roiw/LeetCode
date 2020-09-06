
/*
Get -> returns the key if it exists on the list,

Put -> add new key, evicts the least recently used. 
        
Approach 1: LinkedList + Dictionary of (Key, ListNode)      
*/

public class LRUCache {
    
    // List of element priorities
    private LinkedList<int> _priority;
    private Dictionary<int, (LinkedListNode<int> node, int val) > _elems;
    private int _capacity;
    
    public LRUCache(int capacity) {
        _elems = new Dictionary<int, (LinkedListNode<int> node, int val)>();
        _priority = new LinkedList<int>();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (!_elems.ContainsKey(key)) return -1;
        
        var elem = _elems[key];
        _priority.Remove(elem.node);
        _priority.AddFirst(elem.node);
        return elem.val;       
    }
    
    public void Put(int key, int value) {
        // Modify only.
        if (_elems.ContainsKey(key)) {
            var elem = _elems[key];
            _priority.Remove(elem.node);
            _priority.AddFirst(elem.node);
            _elems[key] = (elem.node, value);
            return;
        }
        
        // Add to LRU
        
        // Check if we need to remove the least recently used..
        if (_priority.Count == _capacity) {
            _elems.Remove(_priority.Last.Value);
            _priority.RemoveLast();
        }
        
        // Add to list and to elems..
        _priority.AddFirst(key);
        _elems.Add(key, (_priority.First, value));      
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */