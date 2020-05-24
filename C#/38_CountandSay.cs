public class Solution {
    public string CountAndSay(int n) {
        
        string b = "1";    
        if (n == 1) return b;
        
        for (int i = 1; i < n; i++){
            char last = b[0];
            int count = 0;
            string s = "";
            for (int j = 0; j < b.Length; j++){
                if (last == b[j])
                    count++;
                else{
                    s += count.ToString() + last;
                    count = 1;
                    last = b[j];
                }
            }
            s += count.ToString() + last;
            b = s;
        }
        
        return b;
    }
}
