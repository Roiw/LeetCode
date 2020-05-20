public class Solution {
    public string MaskPII(string S) {
        string ans = "";
        S = S.ToLower();
        //Email
        if (S.Contains("@")) {
            string[] parts = S.Split('@');
            ans += parts[0][0];
            ans = ans + "*****";
            ans = ans + parts[0][parts[0].Length-1];    
            ans += "@";
            
            for ( int i = 1; i < parts.Length; i++){
                ans = ans + parts[i];
            }
        }
        else {
            string aux = "";
            foreach (char c in S){
                if (c == '+' || c == '-' || c == '(' || c == ')' || c == ' ')
                    continue;
                aux += c;
            }
          
            int k = 1;
            for (int i = aux.Length - 1; i >= 0; i--){
                if (k < 5)
                    ans = aux[i] + ans;
                if (k == 11 || k == 8 || k == 5)
                    ans = "-" + ans;
                if (k >= 5)
                    ans = "*" + ans;
                k++;
            }          
            if (aux.Length > 10)
              ans = '+' + ans;
        }
        return ans;
        
    }
}
