/*

    The Plan:
        - For every character we can: Remove, Modify or Insert
        - We create a decision tree.
        - Starting from the end of both strings we compare elements.

*/

public class Solution {
    
    public int MinDistance(string word1, string word2) {
        
        // A few edge cases.
        if (word1.Equals(word2))
            return 0;
        
        // The memo matrix for the bottom-up DP.
        int[,] memo = new int[word1.Length + 1, word2.Length + 1];
        
        // Setting up initial case.
        memo[0,0] = 0;
        
        // Calculating.
        for (int i = 0; i <= word1.Length; i++) {
            for (int j = 0; j <= word2.Length; j++) {
                
                // If word1 is empty. We will need to insert every char of word2.
                if (i == 0) {
                    memo[0,j] = j;
                    continue;
                }
                // If word2 is empty. We will need to insert every char of word1
                if (j == 0) {
                    memo[i,0] = i;
                    continue;
                }
                
                // Get the minimum cost between removing and inserting.
                int localMin =  Math.Min(memo[i, j - 1], memo[i - 1, j]);
                // Get the minimum cost between removing, inserting and modifying.
                localMin = Math.Min(localMin, memo[ i - 1, j - 1]);
                
                // Save the local minimum + 1 operation if elements are diferent. Otherwise keep the previous  minimum.
                memo[i,j] = word1[i - 1] == word2[j - 1]? memo[ i - 1, j - 1] : localMin + 1;
            }
        }
        
        return memo[word1.Length, word2.Length];
    }
}
