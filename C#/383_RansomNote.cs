public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> letters = new Dictionary<char,int>();
        foreach (char c in magazine){
            if (!letters.ContainsKey(c))
                letters.Add(c,0);
            letters[c]++;
        }
        
        foreach(char c in ransomNote){
            if (!letters.ContainsKey(c))
                return false;
            if (letters[c] == 0)
                return false;
            letters[c]--;
        }
        return true;
    }
}
