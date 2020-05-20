public class StockSpanner {
    Stack<(int,int)> stock = new Stack<(int,int)>();

    public StockSpanner() {
        stock = new Stack<(int,int)>();
    }
    
    public int Next(int price) {       
        int ans = 1;
        while (stock.Count > 0 && stock.Peek().Item1 <= price) 
            ans += stock.Pop().Item2;
              
        stock.Push((price, ans)); 
        return ans;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */