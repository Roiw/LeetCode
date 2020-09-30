public class Solution {
    public string ThousandSeparator(int n) {
        string nString = n.ToString();
        LinkedList<char> lst = new LinkedList<char>();
        
        int pos = nString.Length;
        int i = 0;
        while (pos --> 0) { 
            if (i == 3) { lst.AddFirst('.'); i = 0; }
            lst.AddFirst(nString[pos]);
            i++;
        }
        
        StringBuilder sb = new StringBuilder("", nString.Length);
        foreach (var c in lst) {
            sb.Append(c);
        }
        
        
        return sb.ToString();
    }
}
