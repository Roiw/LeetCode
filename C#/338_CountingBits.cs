public class Solution {
    public int[] CountBits(int num) {
        int[] arr = new int[num + 1];
        if (num == 0) return new int[1] {0};
        if (num == 1) return new int[2] {0,1};
        
        // Initializing with some values..
        arr[0] = 0; arr[1] = 1;
        int lastS = 2;
        for (int i = 2; i <= num; i++) {          
            double sqr = Math.Log(i,2);
            lastS = (sqr == Math.Truncate(sqr)) ? i : lastS;
            int n = i ^ lastS;
            arr[i] = arr[n] + 1;
        }
        return arr;
    }
}
