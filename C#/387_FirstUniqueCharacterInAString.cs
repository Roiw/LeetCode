public class Solution {
    
    public class Node {
        public Node Next;
        public Node Prev;
        public int Index;
    }
    
    public int FirstUniqChar(string s) {
      
        Dictionary<char, Node> chars = new Dictionary<char,Node>();
        Node Head = null;
        Node Last = null;
        
        for (int i = 0; i < s.Length; i++){
            if (!chars.ContainsKey(s[i])) {
                Node n = new Node();
                n.Index = i;
                if (Head == null){
                    Head = n;
                    Last = n;
                    
                } else {
                    Last.Next = n;
                    n.Prev = Last;
                    Last = n;
                }
                
                chars.Add(s[i], n);
            }
            else{
                Node n = chars[s[i]];
                if (n == null) {continue;}
                if (n == Head && n == Last){
                    Head = null;
                    Last = null;
                }
                else if (n == Head) {
                    if (n.Next != null)
                        n.Next.Prev = null;
                    
                    Head = n.Next;
                    
                } else if (n == Last) {
                    if (n.Prev != null)
                        n.Prev.Next = null;
                    
                    Last = n.Prev;
                }
                else {
                    n.Prev.Next = n.Next;
                    n.Next.Prev = n.Prev;
                }
                
                chars[s[i]] = null;
            }        
        }
        if (Head == null)
            return -1;
        else
            return Head.Index;     
    }
}
