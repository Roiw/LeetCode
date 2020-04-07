public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        List<Dictionary<char,int>> sets = new List<Dictionary<char,int>>();
        IList<IList<string>> ans = new List<IList<string>>();
        if (strs.Length == 0) return ans;
        
        // initializing..
        ans.Add(new List<string>(){strs[0]});
        sets.Add(new Dictionary<char,int>());
        foreach (char c in strs[0]) {
            if (sets[0].ContainsKey(c)) sets[0][c]++;
            else sets[0].Add(c,1);
        }
            
        // Foreach string do the following..
        for (int i = 1; i < strs.Length; i++) {
            // Check with each element on our list of founds..
            bool checkedAllElements = true;
            for(int j = 0; j < ans.Count; j++) {
                // if is the same length it could be an anagram..
                if (ans[j][0].Length == strs[i].Length) {
                    Dictionary<char,int> counter = new Dictionary<char,int>();
                    // Check each letter with it's respective set (same id as list of founds)..
                    bool checkAllCharsGood = true;
                    for (int k = 0; k < strs[i].Length; k++) {
                        if (!sets[j].ContainsKey(strs[i][k])){
                            // Case this is not an anagram.. missing a letter
                            checkAllCharsGood = false;
                            break;
                        } else {
                            if (counter.ContainsKey(strs[i][k])) {counter[strs[i][k]]++;}
                            else counter.Add(strs[i][k], 1);
                            
                        }    
                    }
                    
                    // At this point all characters on the string match the element we are checking.
                    // We check for amount of characters..
                    if (checkAllCharsGood) {              
                        // Check character count..
                        foreach (KeyValuePair<char,int> kvp in counter){
                            if (sets[j][kvp.Key] != kvp.Value) {
                                // Not an anagram, sizes dont match..
                                checkAllCharsGood = false;                        
                                break;  
                            }
                        }
                         if (!checkAllCharsGood) continue;
                                         
                        // Found an anagram!
                        ans[j].Add(strs[i]);
                        checkedAllElements = false;
                        break; // Go to next string..
                    }
                    
                } else {
                    continue;
                }
            }
            if (checkedAllElements){
                // Checked all elements.. this seems like a new elements to add!
                ans.Add(new List<string>(){strs[i]});
                sets.Add(new Dictionary<char,int>());
                int index = sets.Count-1;
                foreach (char c in strs[i]) {
                    if (sets[index].ContainsKey(c)) sets[index][c]++;
                    else sets[index].Add(c,1);
                }
            }
        }        
        return ans;
    }
}
