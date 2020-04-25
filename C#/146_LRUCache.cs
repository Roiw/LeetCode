public class LRUCache {
    
    Dictionary<int,(int, LinkedListNode<int>)> vals;
	LinkedList<int> ls;
	private int _count = 0;
	private int _capacity = 0;
    
    public LRUCache(int capacity) {
		ls = new LinkedList<int>();
		vals = new Dictionary<int,(int, LinkedListNode<int>)>();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (!vals.ContainsKey(key))
            return -1;
        
        (int val, LinkedListNode<int> n) = vals[key];     
		int k = n.Value;
        ls.Remove(n);
		vals[key] = (val, ls.AddLast(k));
        return val;
    }
    
    public void Put(int key, int value) {
        if (vals.ContainsKey(key)){
            (int val, LinkedListNode<int> node) = vals[key]; 
            int k = node.Value;
        	ls.Remove(node);
			vals[key] = (value, ls.AddLast(k));
            return;
        }   
            
        if (_capacity == _count) {
            int k = ls.First.Value;
			ls.RemoveFirst();
            vals.Remove(k);       
        } else {
            _count++;
        }
        
        // Add normally..
        vals[key] = (value, ls.AddLast(key));
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
 