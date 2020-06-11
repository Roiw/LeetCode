public class Solution {   
    public void SortColors(int[] nums) {
        int i = -1, j = -1, k = -1;
        for (int a = 0; a < nums.Length; a++){
            if (nums[a] == 0){
                if (j > i) { swap(nums, i+1, a); }
                if (k > j) { swap(nums, j+1, a); }
                i++; j++;
            }
            else if (nums[a] == 1){
                if (k > j) { swap(nums, j+1, a); }
                j++;
            }
            k++;
        }
    }
       
    private int[] swap(int[] nums, int i, int j){
        int aux = nums[i];
        nums[i] = nums[j];
        nums[j] = aux;
        return nums;
    }
}
