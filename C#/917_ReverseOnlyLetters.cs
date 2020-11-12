public class Solution {
    public string ReverseOnlyLetters(string S) {
        Stack<char> letters = new Stack<char>();
        
        foreach(char c in S) {
            if (c >= 65 && c <= 90 || c>= 97 && c <= 122)
                letters.Push(c);
        }
            
        
        string ans = "";
        foreach (char c in S) {
            if (c >= 65 && c <= 90 || c>= 97 && c <= 122)
                ans += letters.Pop();
            else 
                ans += c;
        }
        return ans;
    }
}
