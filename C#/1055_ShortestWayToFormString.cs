public class Solution {
    public int ShortestWay(string source, string target) {
        
        int si = 0;
        int count = 1;
        for (int i = 0; i < target.Length; i++) {
            // check if valid..
            if(!source.Contains(target[i].ToString()))
                return -1;
            
            while(true) {
                if (si == source.Length) {
                    count ++;
                    si = 0;
                }
                if (source[si] == target[i]) {
                    si++;
                    break;
                }
                si++;
            }
        }
        return count;
    }
}
