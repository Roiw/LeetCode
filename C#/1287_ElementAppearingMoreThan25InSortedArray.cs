public class Solution {
    public int FindSpecialInteger(int[] arr) {
        Dictionary<int,int> count = new Dictionary<int,int>();
        
        foreach(int i in arr) {
            if (!count.TryAdd(i, 1))
                count[i]++;
            if (count[i] > arr.Length / 4)
                return i;
        }
        return -1;
    }
}
