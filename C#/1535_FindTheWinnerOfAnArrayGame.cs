public class Solution {
    
    public int GetWinner(int[] arr, int k) {
        int p0 = 0, p1 = 1;
        int wins = 0;
        int maxNumber = 0;
        
        while (p0 < arr.Length) {        
            maxNumber = maxNumber < arr[p0]? arr[p0]:maxNumber;
            if (p1 == arr.Length) { return maxNumber; }
            
            if (arr[p0] > arr[p1])
                wins++;
            else {
                p0 = p1;
                wins = 1;
            }
                
            if (wins == k)
                return arr[p0];
            
            p1++;
        }
        return -1;
    }
}
