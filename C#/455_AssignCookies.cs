public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int content = 0;
        int gi = 0, si = 0;
        while (gi < g.Length && si < s.Length) {
            if (g[gi] <= s[si]){
                content++;  
                gi++;
            } 
            si++;
            
        }
        return content;
    }
}
