public class Solution {
    public bool BackspaceCompare(string S, string T) {
        Stack<char> nS = new Stack<char>();     
        Stack<char> nT = new Stack<char>();    
        foreach(char c in S){
            if (c != '#')
                nS.Push(c);
            else if (nS.Count > 0)
                nS.Pop();
        }
        
        foreach(char c in T){
            if (c != '#')
                nT.Push(c);
            else if (nT.Count > 0)
                nT.Pop();
        }
        
        if (nS.Count != nT.Count) return false;
        
        while(nS.Count > 0) {
            if (nS.Pop() != nT.Pop())
                return false;
        }
        
        return true;
    }
}
