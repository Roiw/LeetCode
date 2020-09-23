public class KthLargest {

    private SortedDictionary<int, int> _elems;
    private int _k = 0, amount;
    public KthLargest(int k, int[] nums) {
        _k = k;
        _elems = new SortedDictionary<int,int>();
        foreach (var i in nums){
            if (_elems.ContainsKey(i))
                _elems[i]++;
            else
                _elems.Add(i, 1);
            amount++;
        }
    }
    
    public int Add(int val) {
        if (_elems.ContainsKey(val))
                _elems[val]++;
        else
                _elems.Add(val, 1);
        amount++;
        
        while (amount > _k) {
            if (_elems.First().Value == 1)
                _elems.Remove(_elems.First().Key);
            else
                _elems[_elems.First().Key]--;
            amount--;
        }
        
        return _elems.First().Key;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */