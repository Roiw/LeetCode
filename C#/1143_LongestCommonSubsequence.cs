/*

Logest Common Subsequence (LCS) - Dynamic programming O(N * M)

    - Tabulation:
        - We create a table that has text1 + 1 as column length and text2 + 1 as row length.
        - Starting from the top position whe fill each cell with:
            If text1[col] == text[row] => 1 + Table[row - 1][col - 1]
            Else Max[table[row-1], table[col-1]]
        - The max sum is at Table[n][m] (last cell)
*/

public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        int[][] table = new int[text1.Length + 1][];
        table[0] = new int[text2.Length + 1]; 
        for (int i = 0; i < text1.Length; i++) {
            table[i + 1] = new int[text2.Length + 1]; 
            for (int j = 0; j < text2.Length; j++) {
                table[i + 1][j + 1] = text1[i] == text2[j] ? table[i][j] + 1 : Math.Max(table[i][j + 1], table[i + 1][j]);
            }
        }     
        return table[text1.Length][text2.Length];
    }
}

// Same approach different coding..
public class Solution {
    
    public int LongestCommonSubsequence(string text1, string text2) {
        int[][] table = new int[text1.Length + 1][];
        table[0] = new int[text2.Length + 1];
        for (int i = 1; i <= text1.Length; i++) {
            table[i] = new int[text2.Length + 1];
            for (int j = 1; j <= text2.Length; j++) {
                if (text1[i-1] == text2[j-1])
                    table[i][j] = table[i-1][j-1] + 1;
                else
                    table[i][j] = Math.Max(table[i-1][j],table[i][j-1]);
            }   
        }
        return table[text1.Length][text2.Length];
    }
}
