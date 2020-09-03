// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator {
    private bool _hasNext;
    private IEnumerator<int> _iterator;
    
    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator) {
        // initialize any member here.
        _hasNext = true;
        _iterator = iterator;
    }
    
    // Returns the next element in the iteration without advancing the iterator.
    public int Peek() {
        return _iterator.Current;
    }
    
    // Returns the next element in the iteration and advances the iterator.
    public int Next() {
        int oldVal = _iterator.Current;
        _hasNext = _iterator.MoveNext();
        return oldVal;
    }
    
    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext() {
		return _hasNext;
    }
}
