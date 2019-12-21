public class Solution {
    public int Reverse(int x) {
        int range = Convert.ToInt32(Math.Pow(2,31)-1);
        if (x > range)
            return 0;
        if (x < range * -1)
            return 0;
    
        
        
        string n = x.ToString();
        bool boolIsNeg = n[0] == '-' ? true : false;
        int lastIndex = boolIsNeg ? 1 :  0;
        
        int flipped = 0;
        string ans = "";
        for(int i = n.Length -1; i >= lastIndex; i--) {
            ans += n[i];
        }
        
        try {
            flipped = Int32.Parse(ans);
        }catch (OverflowException e) {
            return 0;
        }
        
        
        
        if (boolIsNeg)
            flipped = flipped * -1;
        
        return flipped;
    }
}