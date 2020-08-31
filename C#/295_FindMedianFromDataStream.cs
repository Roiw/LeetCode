public class MedianFinder {
    
    private List<int> _stream;    

    /** initialize your data structure here. */
    public MedianFinder() {
         _stream = new List<int>();
    }
    
    private int BinarySearch(List<int> lst, int target, int min, int max) {
        if (min > max) {
            return ~min; // Lst.count or 0
        }
        
        int mid = min + (max - min)/2;
        
        if (lst[mid] < target)
            return BinarySearch(lst, target, mid + 1, max);
        else
            return BinarySearch(lst, target, min, mid - 1);
    }
    
    public void AddNum(int num) {
        
        int pos = BinarySearch(_stream, num, 0, _stream.Count - 1);
        pos = pos < 0? ~pos : pos;
        if (pos == _stream.Count)
            _stream.Add(num);
        else
            _stream.Insert(pos, num);
    }
    
    public double FindMedian() {
        int mid = _stream.Count / 2; 
        
        if (_stream.Count % 2 == 0) 
            return (double)(_stream[mid - 1] + _stream[mid])/2;
        else
            return _stream[mid];
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
 