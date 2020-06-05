public class Solution {
    public void ReverseString(char[] s) {
        for(int i = 0; i < s.Length/2; i++){
            char aux = s[s.Length-1-i];
            s[s.Length-1-i] = s[i];
            s[i] = aux;
        }
    }
}
