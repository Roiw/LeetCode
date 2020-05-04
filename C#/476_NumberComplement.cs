public class Solution {
    public int FindComplement(int num) {
        int i = (int)Math.Ceiling(Math.Log(num,2));
        return ~((~0 << i) | num);
    }
}
