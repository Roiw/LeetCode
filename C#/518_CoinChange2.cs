public class Solution {
    // 39
    public int Change(int amount, int[] coins) {
        coins);
        int ans = 0;
        for (int i = 0; i < coins.Length; i++){
            ans = amount % coins[i] == 0 ? ans+1: ans;
            for (int j = i + 1; j < coins.Length; j++){
                int k = 1, aux = amount - coins[j];
                while (aux >= coins[i]){
                    ans = aux % coins[i] == 0 ? ans + 1: ans;
                    k++;
                    aux = amount - coins[j] * k;
                }
            }
        }
        return ans;
    }
    
    public int Change(int amount, int[] coins) {
        if (coins[0] == amount)
            return 1;
        
        int ans = 0;
        for (int i = 0; i < coins.Length; i++){
            ans = amount % coins[i] == 0 ? ans+1: ans;
            int k = 1, aux = amount - coins[j];
            while (aux >= coins[i]){
                ans = aux % coins[i] == 0 ? ans + 1: ans;
                k++;
                aux = amount - coins[j] * k;
            }
        }
        return ans;
    }
}

// 1
// 2 , 3 ,4, 5
// 2 (6)
// 7
// 8

10x1
1x2 8x1
2x2 6x1
3x2 4x1
4x2 2x1
1x5 5x1 
5x2
2x5

5x1 2x2 1x1


