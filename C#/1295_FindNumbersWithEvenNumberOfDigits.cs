public class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;
        foreach (int n in nums){
            if (n.ToString().Length % 2 == 0)
                count++;
        }
        return count;
    }
}
