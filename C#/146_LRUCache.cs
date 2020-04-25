public class LRUCache {
    
    private class Node {
        public Node Front;
        public Node Back;
        public int Key;
        public Node(){
            Back = null;
            Front = null;
        }
    }
    
    Dictionary<int,(int, Node)> vals = new Dictionary<int,(int, Node)>();
    
    private Node _manager = null;
    private int _capacity = 0;
    private int _count = 0;
    
    public LRUCache(int capacity) {
        _manager = new Node();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (!vals.ContainsKey(key))
            return -1;
        
        (int val, Node n) = vals[key];     
        MoveToFront(n);
        return val;
    }
    
    public void Put(int key, int value) {
        if (vals.ContainsKey(key)){
            (int val, Node node) = vals[key]; 
            vals[key]= (value, node);
            MoveToFront(node);
            return;
        }   
            
        if (_capacity == _count) {
            int k = RemoveLessPriority();
            vals.Remove(k);       
        } else {
            _count++;
        }
        
        // Add normally..
        Node n = new Node();
        n.Key = key;
        if (_count == 1) _manager.Back = n;
        ConnectAtFront(n);
        vals.Add(key, (value, n));   
    }
    
    // Moves an element on our list to the front.
    private void MoveToFront(Node n){
        if (_manager.Front == n)
            return;
        
        // Disconnect N..
        if (n.Front != null) n.Front.Back = n.Back;
        if (n.Back != null) n.Back.Front = n.Front;
            
        // Connect at beginning..
        n.Back = _manager.Front;
		if(_manager.Back == n && n.Front != null) _manager.Back = n.Front; 
        if (_manager.Front != null) _manager.Front.Front = n;
        _manager.Front = n;
        n.Front = null;
    }
    
    private void ConnectAtFront(Node n){
        if (_manager.Front != null) _manager.Front.Front = n;
        n.Back = _manager.Front;
        _manager.Front = n;
    }
    
    private int RemoveLessPriority(){
        if (_manager.Back != null) {
            int k = _manager.Back.Key;
            _manager.Back = _manager.Back.Front;
            return k;
        } 
        return -1;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
 