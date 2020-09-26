/*

    The maximum XOR is the two numbers with the maximum amount of different 0's and 1's
    Ex:     0 1 0 1
     and    1 0 1 0  -> XOR == 1111
     
     Idea:
        - It's very important to make the trie from higher bit to lower.
          Something related with reducing overlap of numbers?
*/

public class Solution {
    
    public class TrieNode {
        public TrieNode isZero;
        public TrieNode isOne;
    }
    
    public int FindMaximumXOR(int[] nums) {
        
        TrieNode root = new TrieNode();
        // Build the Trie
        foreach (int n in nums) {
            var node = root;
            for (int i = 31; i >= 0; i--) {
                if ( ( n & (1 << i) ) > 0) { // get a bit
                    node = ( node.isOne ??= new TrieNode() );
                }
                else {
                    node = ( node.isZero ??= new TrieNode() );
                }
            }
        }
        
        int max  = 0;
        int result = 0;
        
        // Check minimum
        foreach (int n in nums) {
            var node = root;
            int aux  = 0;
            for (int i = 31; i >= 0; i--) {
                if ( ( n & (1 << i) ) > 0)  { 
                    aux = node.isZero != null? aux | 1 << i : aux;
                    node = node.isZero != null? node.isZero : node.isOne;
                }      
                else {
                   aux = node.isOne != null? aux | 1 << i : aux;
                   node = node.isOne != null? node.isOne : node.isZero;
                }
            }
            max = aux > max? aux : max;
        }
        
        return max;
    }
}
