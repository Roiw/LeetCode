public class Solution {
    public int MaxSubArray(int[] nums) {
        int max = int.MinValue;
        int sum = 0;
        foreach (int i in nums) {
           int c = i+sum;
           if (i > max) {
               max = i;
          
               }
           if (c > max) {
               max = c;
               sum = c;
              } 
            else if (c< 0)
                sum = 0;
            else
                sum = c;
        }
        return max;
    }
}
