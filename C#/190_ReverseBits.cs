public class Solution {
    public uint reverseBits(uint n) {
        uint ans = 0;
        for (uint i = 0; i < 32; i++) {
            ans <<= 1;
            ans |= (n & (uint)1);
            n >>= 1;
        }
        return ans;
    }
}
