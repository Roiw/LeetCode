public class Solution {
    public int FirstMissingPositive(int[] nums) {
        
        // The array must be complete! That means from nums[0] = 1 to nums[N-1] = N.
        // Therefore we add the numbers we find to their respective array position and mark the ones we don't want with 0;
        // On a second pass over the array we return the smallest index of 0 we had marked.
        
        for (int i = 0; i < nums.Length; i++) {
            
            if (nums[i] <= 0 || nums[i] > nums.Length) {nums[i] = 0; continue;}
            if (nums[i] == i + 1) continue;
            
            int correctPos = nums[i] - 1;
            int toChange = nums[i];
            nums[i] = 0;
            while (true){
                // Do changes.
                if (nums[correctPos] <= 0 || toChange > nums.Length || nums[correctPos] == correctPos + 1) {
                    nums[correctPos] = toChange;
                    break;
                }
                int temp = nums[correctPos];
                nums[correctPos] = toChange;
                correctPos = temp - 1;
                toChange = temp;
            }
            
        }
        
        for (int i = 0; i < nums.Length; i++){
            if (nums[i] == 0) return i+1;
        }
        return nums.Length + 1;
    }
}
