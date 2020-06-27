public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] arr = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++){
            arr[nums[i]-1] += 1;
        }
        int missing = -1, repeated = -1;
        for (int i = 0; i < nums.Length; i++){
            missing = arr[i] == 0? i + 1 : missing;
            repeated = arr[i] == 2? i + 1: repeated;
        }
        return missing == -1? new int[0] : new int[]{repeated, missing};
    }
}
