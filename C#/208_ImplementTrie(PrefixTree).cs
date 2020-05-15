public class Trie {

    private class TreeNode{
        public char Val;
        public List<TreeNode> Childs;
        public TreeNode (List<TreeNode> childs = null, char val='*'){
            Val = val;
            Childs = childs == null ? new List<TreeNode>(): childs;
        }
    }
    
    private TreeNode root;
    
    private TreeNode CreateEndOrChar(string s, int i) {
        TreeNode n = null;
        if (s.Length == i)
            n = new TreeNode(new List<TreeNode>(), '*');
        else
            n = new TreeNode(new List<TreeNode>(), s[i]);
        return n;
    }
    
    private void InsertWord(TreeNode root, string s, int i){    
        if (s.Length < i)
            return;  
        
        TreeNode n = null;
        
        // Add node to childlist if neeeded.
        foreach (TreeNode c in root.Childs) {
            if (s.Length == i) break;
            n = c.Val == s[i] ? c : n;
        }      
        
        if (n == null) {
            n = CreateEndOrChar(s, i);
            root.Childs.Add(n);
        }
     
        InsertWord(n, s, i + 1);
        return;
    }
    
    private bool SearchWord(TreeNode root, string s, int i){
        if (s.Length == i){
            foreach (TreeNode e in root.Childs){
                if (e.Val == '*')
                    return true;
            }
            return false;
        }
        
        foreach (TreeNode e in root.Childs){
            if (e.Val == s[i])
                return SearchWord(e, s, i + 1);
        }
        return false;
    }
    
    private bool Contains(TreeNode root, string s, int i){
        if (s.Length == i)
            return true;
        
        foreach (TreeNode e in root.Childs){
            if (e.Val == s[i])
                return Contains(e, s, i + 1);
        }
        return false;
    }
    
    /** Initialize your data structure here. */
    public Trie() {
        root = new TreeNode(new List<TreeNode>(), '*');
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        InsertWord(root, word, 0);
        
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        return SearchWord(root, word, 0);
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        return Contains(root, prefix, 0);
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
 