public class Solution {
    public string GenerateTheString(int n) {
        string rst = "";
        for (int i = 0; i < n - 1; i++) {
            rst += 'a';
        }
        if ( n % 2 == 0){
            rst += 'b';
        }
        else
            rst += 'a';
        
        return rst;
    }
}