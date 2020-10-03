public class Solution {
    public string SimplifyPath(string path) {
        
        string fix = path.Replace("//", "/");  
        string[] splitted = fix.Split("/");
        LinkedList<string> ans = new LinkedList<string>();
        foreach (string s in splitted) {
            if (s == "." || s == "") continue;
            if ( s == ".." ) {
                if (ans.Count > 0) ans.RemoveLast();
            }     
            else
                ans.AddLast(s + "/");
        }
        
        StringBuilder sb = new StringBuilder("/", path.Length);
        
        foreach (String s in ans) { sb.Append(s); }
        
        sb.Remove(sb.Length-1, 1);
        
        if (sb.Length == 0) sb.Append("/");
        
        return sb.ToString();
    }
}