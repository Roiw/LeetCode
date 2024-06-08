public class Solution 
{
    public string ReplaceWords(IList<string> dictionary, string sentence) 
    {
        // 1: For each word find the root.
        //  1.1: Turn "dictionary" into a trie for performance.
        //  1.2: For each character of word trie no navigate the trie. 
        //  1.3: If found on trie, then we keep that root.
        // 2: Save each root on a string (string builder to optimize)

        Trie trie = new();
        foreach (string w in dictionary)
        {
            trie.Add(w);
        }
        string[] words = sentence.Split(" ");
        StringBuilder sb = new();
        foreach (string w in words)
        {
            string s = trie.SearchRoot(w);
            if (s != null)
            {
                sb.Append(s);
            }
            else
            {
                sb.Append(w);
            }
            sb.Append(" ");
        }
        return sb.ToString().Trim();
    }

    public class Trie
    {
        private class TrieNode
        {
            public Dictionary<char, TrieNode> NextElements = new();
            public bool IsFinal = false;
        }

        private TrieNode root = new();
        
        public void Add(string word)
        {
            var current = root;
            foreach (char c in word)
            {
                if (!current.NextElements.ContainsKey(c))
                {
                    // Adding a child to current.
                    current.NextElements.Add(c, new TrieNode());
                }
                current = current.NextElements[c]; // Walk down to child.
            }
            current.IsFinal = true;
        }
        // SearchRoot
        public string SearchRoot(string word)
        {
            StringBuilder sb = new();
            var current = root;
            foreach (char c in word)
            {
                if (current.NextElements.ContainsKey(c))
                {
                    sb.Append(c);
                    current = current.NextElements[c];
                    if(current.IsFinal)
                    {
                        return sb.ToString();
                    }
                }
                else
                    break;
            }
            return null;
        }
    }
}