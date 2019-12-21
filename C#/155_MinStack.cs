public class MinStack {

    private Stack<int> _stack; 
    private Stack<int> _minStack;
    private int _min;
    /** initialize your data structure here. */
    public MinStack() {
        _stack = new Stack<int>();
        _minStack = new Stack<int>();
        _minStack.Push(int.MaxValue);
    }
    
    public void Push(int x) {
        _stack.Push(x);
        
        if (x <= _minStack.Peek()) {
            _minStack.Push(x);
        }	    
    }
    
    public void Pop() {
        int i = _stack.Pop();
        
        if (i == _minStack.Peek()){
            _minStack.Pop();
        }          
    }
    
    public int Top() {
        return _stack.Peek();
    }
    
    public int GetMin() {
        return _minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */

