public class Solution {
    public bool IsValid(string s) {
      	
        Stack<char> opens = new Stack<char>();
        char current; // Current character  
        foreach (char c in s) {
            if (c.Equals('(') || c.Equals('[') || c.Equals('{'))
                opens.Push(c);
            else {
                if (opens.Count == 0)
                    return false;
                char popped = opens.Pop();
                if (c.Equals(')') && popped.Equals('('))
                    continue;
                if (c.Equals(']') && popped.Equals('['))
                    continue;
                if (c.Equals('}') && popped.Equals('{'))
                    continue;
                return false;
            }
        }
        if(opens.Count > 0)
            return false;

        return true;
    }
}
