public class Solution {
    public string ReverseWords(string s) {
        string[] splitted = s.Split(" ");
        string ans = "";
        int i = splitted.Length;
        while (i --> 0) {
            if (splitted[i] == "") continue;
            ans += (splitted[i] + " ");
        }         
        return ans.Trim();
    }
}
