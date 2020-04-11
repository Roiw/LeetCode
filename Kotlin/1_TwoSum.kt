class Solution {
    fun twoSum(nums: IntArray, target: Int): IntArray {
        
        for (i in 0..nums.size - 1) {
            for (j in 0..nums.size - 1){
                if (nums[i] + nums[j] == target && i != j){
                    return intArrayOf(i,j)
                }
            }
        }
        return intArrayOf()
    }
}
