public class Solution {
    public string RemoveOuterParentheses(string S) {
        string rtn = "";
        int count = 0;
        
        foreach (char c in S) {
            if (count == 0 && rtn.Length > 0)
                rtn = rtn.Remove(rtn.Length -1);
            if (count >= 1) 
                rtn = rtn + c;
            if (c.Equals('('))
                count++;
            else
                count--;
        }
        if (count == 0 && rtn.Length > 0)
            rtn = rtn.Remove(rtn.Length -1);
        return rtn;
    }
}
