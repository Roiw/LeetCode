public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0) return 0;
        Stack<int> income = new Stack<int>();
        int min = prices[0];
        int max = prices[0];
        for (int i = 1; i < prices.Length; i++){
            if (prices[i] < min){
                income.Push(max-min);
                max = prices[i];
                min = prices[i];
            }
            if (prices[i] > max)
                max = prices[i];
        }
        income.Push(max-min);
        max = Int32.MinValue;
        while(income.Count > 0){
            int i = income.Pop();
            max = i > max ? i : max; 
        }
        return max;
    }
}
