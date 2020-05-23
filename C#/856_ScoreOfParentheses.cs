public class Solution {
    
    // The aux stack has two kind of elements on it: '(' or 'N'
    
    // Whenever we find an '(' on the string we add to the stack with value 1.
    
    // If ')' we take action! It goes as following..
    
    // Case top of the stack is 'N': 
    //  1 - We remove it and save it's value. We keep removing conssecutive 'N's until we find a '('.
    //  2 - Multiply the values we removed by 2
    //  3 - Remove the '(' we found on step 1.
    //  4 - Reinsert on the Stack as an N
    
    // Case top of the stack is '('
    //  1 - Remove '(' 
    //  2 - Inser an 'N' on the stack with value 1.
    
    
    public int ScoreOfParentheses(string S) {
        Stack<(char, int)> aux = new Stack<(char, int)>();
        foreach (char e in S){
            if (e == '(')
                aux.Push(('(', 1));
            if (e == ')') {
                (char c, int i) = aux.Pop();
                
                // Case '('
                if (c == '(')
                    aux.Push(('N', 1));
                
                // Case 'N'
                if (c == 'N'){
                    int t = i;
                    while (aux.Count > 0){
                        (char c2, int i2) = aux.Pop();
                        if (c2 == 'N') {
                            t += i2;
                        }
                        if (c2 == '('){
                            aux.Push(('N', t * 2));
                            break; // Finished
                        }
                    }
                }
            }   
        }
        // At the end we sum each remaining value on the stack..
        int ans = 0;
        while (aux.Count > 0){
            (char c, int i) = aux.Pop();
            ans += i;
        }
        return ans;
    }
}
