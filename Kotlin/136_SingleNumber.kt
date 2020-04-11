class Solution {
    fun singleNumber(nums: IntArray): Int {
        var resp = 0;
        for (n in nums)
            resp = resp.xor(n)
        return resp
    }
}
