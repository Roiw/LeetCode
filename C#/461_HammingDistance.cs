public class Solution {
    public int HammingDistance(int x, int y) {
        BitArray bts = new BitArray(BitConverter.GetBytes((x^y)));
        int i = 0;
        foreach (bool b in bts){
            if (b)
                i++;
        }
        return i;       
    }
}
