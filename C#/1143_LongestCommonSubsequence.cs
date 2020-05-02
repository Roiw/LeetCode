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
