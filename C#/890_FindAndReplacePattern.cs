public class Solution {
    public IList<string> FindAndReplacePattern(string[] words, string pattern) {
        
        List<string> rtn = new List<string>();
        foreach (string w in words){
            bool isOk = true;
            Dictionary<char, char> d  = new Dictionary<char, char>();
            HashSet<char> added = new HashSet<char>();
            for (int i = 0; i < pattern.Length; i++) {
                if(!d.ContainsKey(pattern[i])) {
                    if(added.Add(w[i]))
                        d.Add(pattern[i], w[i]);
                    else {
                        isOk = false;
                        break;
                    }
                }          
                else {
                    if(d[pattern[i]] != w[i]){
                        isOk = false;
                        break;
                    }
                }
            }
            if (isOk)
                rtn.Add(w);
        }
        return rtn;
    }
}