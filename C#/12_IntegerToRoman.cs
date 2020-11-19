public class Solution {
    
    int[] vals = new int[] {1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};
    string[] chars = new string[] {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};

    
    public string IntToRoman(int num) {  
        for (int i = vals.Length - 1; i >= 0; i--) {
            if (vals[i] <= num)
                return chars[i] + IntToRoman(num - vals[i]);
        }
        return "";
    }
}
