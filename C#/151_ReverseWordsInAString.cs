public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        string[] splitted = s.Split(' ');
        StringBuilder ans = new StringBuilder("", s.Length);
        int i = splitted.Length;
        while (i --> 0) {
            if (splitted[i] == "") continue;
            ans.Append(splitted[i]);
            if (i > 0) ans.Append(" ");
        }         
        return ans.ToString();
    }
}
