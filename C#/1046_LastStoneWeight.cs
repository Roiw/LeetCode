public class Solution {
    public int LastStoneWeight(int[] stones) {
        if (stones.Length == 1) return stones[0];
        // Go over the array and get the biggest ones..
        // Smash.. replace the number on the 1 position of the array.. put 0 on the other one..
        // repeat until we have 1 stone or 0 stones..
        // O(N2)
        int a = 0, iA = -1;
        int b = 0, iB = -1;
        int lastResult = 0;
        int stoneCount = stones.Length; // Checks if we have more than 1 stone..
        while (stoneCount > 1) {
            stoneCount = 0;
            for (int i = 0; i < stones.Length; i++) {
                if (stones[i] >= a) {
                    if (iA != - 1){
                        b = a; iB = iA;
                    }
                    a = stones[i];
                    iA = i;
                }
                else if (stones[i] > b){
                    b = stones[i];
                    iB = i;
                }
                if (stones[i] > 0)
                    stoneCount++;
            }
            // Found the biggest stones..
            // ..updating stones array
            stones[iA] = a - b;
            if (iB != -1) stones[iB] = 0;
            lastResult = a - b;
            iA = -1; iB = -1;
            a = 0; b = 0;
        }
        if (stoneCount == 0)
            return 0;
        else 
            return lastResult;        
    }
}
