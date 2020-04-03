public class RecentCounter {
    
    private Queue<int> pings = new Queue<int>();
    int last = 0;
    
    public RecentCounter() {
        
    }
    
    public int Ping(int t) {
        while (pings.Count > 0) {
            if (t - last <= 3000) {
                pings.Enqueue(t);
                return pings.Count;
            } else {
                pings.Dequeue();
                last = pings.Count > 0 ? pings.Peek() : 0;
            }
        }
        pings.Enqueue(t);
        last = t;
        return 1;
    }
}

/**
 * Your RecentCounter object will be instantiated and called as such:
 * RecentCounter obj = new RecentCounter();
 * int param_1 = obj.Ping(t);
 */
