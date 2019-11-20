public class Solution {
    public int BalancedStringSplit(string s) {
        int count = 0;
        int total = 0;
        foreach(char c in s){
            if (c == 'R')
                count++;
            else
                count--;
            if(count == 0)
                total++;
        }
        return total;
    }
}
