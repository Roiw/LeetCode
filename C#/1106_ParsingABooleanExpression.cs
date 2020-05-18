public class Solution {
    
    private List<string> FindSubstring(string s) {
        List<string> strs = new List<string>();
        int opening = 0;
        int j = -1;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '(') {
                opening++;
                j = j == -1? i : j;
            }
                
            if (s[i] == ')'){
                opening--;
                if (opening == 0) {
                    strs.Add(s.Substring(j-1, i - j +2));
                    j = -1;
                }
            }
			if (opening == 0 && (s[i] == 't' || s[i] == 'f'))
				strs.Add(s[i] + "");
        }
        if (strs.Count == 0) return null;
        return strs;
    }
    
    public bool ParseBoolExpr(string expression) {
        if (expression.Length == 1)
            return expression[0] == 't' ? true : false;
        
        char op = expression[0];
        string rest = expression.Substring(2, expression.Length -3);
        
        List<string> s = FindSubstring(rest);
        
        // Base case..
        if (s == null){
            string[] c = rest.Split(',');
            bool result = c[0] == "t" ? true : false;
            result = op == '!' ? !result : result;
            
            for (int i = 1; i < c.Length; i++){
                bool current = c[i] == "t" ? true : false;
                if (op == '&')
                    result = result && current;
                else
                    result = result || current;
            }
            return result;
        }
        
        if (op == '!') return !(ParseBoolExpr(s[0]));

        bool ans = ParseBoolExpr(s[0]);
        for (int i = 1; i < s.Count; i++){
            if (op == '&')
                ans = ans && ParseBoolExpr(s[i]);
            if (op == '|')
                ans = ans || ParseBoolExpr(s[i]);
        }
        return ans;      
    }
}
