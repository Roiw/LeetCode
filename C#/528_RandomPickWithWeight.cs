public class Solution {

    double[] amounts;
    public Solution(int[] w) {
        amounts = new double[w.Length+1]; 
        amounts[0] = 0;
        for (int i = 0; i < w.Length; i++) {   
            amounts[i + 1] = w[i] + amounts[i];
        }
    }
    
    public int PickIndex() {
        
        Random random = new Random(); 
        int n = random.Next(0, (int)amounts[amounts.Length-1]);  
               
        for (int i = 0; i < amounts.Length - 1; i++) {
            if (amounts[i] <= n && n < amounts[i+1]) 
                return i;
        }
        return amounts.Length-2; 
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */
 