public class Solution {
    public int TitleToNumber(string s) {
        int col = 0, j = 0;
        for (int i = s.Length-1; i > 0; i--){
            col += (int)Math.Pow(26,(float)i) * (s[j] - 64);
            j++;
        }
        return col + (s[s.Length-1] - 64);
    }
}
