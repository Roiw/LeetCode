public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim();
        string[] words = s.Split(' ');
        if (words.Length > 0)
            return words[words.Length-1].Length;
        else
            return 0;
    }
}
