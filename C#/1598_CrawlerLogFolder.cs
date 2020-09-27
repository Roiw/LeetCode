/*
    Use a linked list

*/

public class Solution {
    public int MinOperations(string[] logs) {
        int count = 0;      
        foreach (string s in logs) {
            if (s == "./") {
                continue;
            }
            else if (s == "../") {
                count = Math.Max(count - 1, 0);
            }
            else {
                count ++;    
            }
        }
        return count;
    }
}
