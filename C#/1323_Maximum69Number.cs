public class Solution {
    public int Maximum69Number (int num) { 
        string s = num.ToString();
        int i = 0;
        string rst = "";
        for (i = 0; i < s.Length; i++) {
            if (s[i] == '6')
                break;
            else
                rst += s[i];
        }
        if (i == s.Length)
            return num;
        
        rst += "9";
        rst += s.Substring(i + 1);
        return Int32.Parse(rst);
    }
}
