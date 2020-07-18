public class Solution {
    public string RemoveDuplicates(string S) {
        string ans = "";
        bool shouldRun = true;
        while (shouldRun) {
            shouldRun = false;
            int i = 0;
            for (i = 0; i < S.Length - 1; i++) {
                if (S[i] == S[i+1]){
                    i = i + 1; // increment
                    shouldRun = true;
                } 
                else ans += S[i];
            }
            if (i == S.Length-1) ans += S[i];
            S = ans;
            ans = "";
        }
        return S;
    }
}
