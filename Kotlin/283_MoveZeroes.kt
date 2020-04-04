class Solution {
    fun moveZeroes(nums: IntArray): Unit {
        var a = 0;
        for (n in 1..(nums.size-1)){
            if(nums[n] != 0 && nums[a] == 0 ){
                nums[a] = nums[n];
                nums[n] = 0;
                a = a+1;
            }
            if (nums[n] == 0 && nums[a]!=0 ){
                a = n;
            }
        }
        return;
    }
}
