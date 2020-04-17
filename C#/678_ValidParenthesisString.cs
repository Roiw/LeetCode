public class Solution {
    public bool CheckValidString(string s) {
    
        
        Stack<int> open = new Stack<int>();
        Stack<int> close = new Stack<int>();
        List<int> asterisk = new List<int>();
        
        for(int i = 0; i < s.Length; i++){
            if (s[i]== '('){
                open.Push(i);
            }
            if (s[i] == ')'){
                if (open.Count == 0 && asterisk.Count < close.Count + 1)
                    return false; // Optimizaiton..
                
                if (open.Count > 0)
                    open.Pop();
                else
                    close.Push(i);
            }
            if (s[i] == '*')
                asterisk.Add(i);
        }
        
        // Using asterisk..
        
        while (open.Count > 0 && asterisk.Count > 0){
            int o = open.Pop();
            int a = asterisk[asterisk.Count-1];
            if (o > a)
                return false;
            asterisk.RemoveAt(asterisk.Count-1);
        }
        
        while (close.Count > 0 && asterisk.Count > 0){
            int c = close.Pop();
            if (c < asterisk[0])
                return false;
        }
        
        if (open.Count == 0 && close.Count == 0)
            return true;
        
        else 
            return false;
    }
}
