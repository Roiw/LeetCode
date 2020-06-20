public class Solution {
    public int MyAtoi(string str) {   
        string number = "";
        str = str.Trim();
        for(int i = 0; i < str.Length; i++) {
            if ( (str[i] == '-' || str[i] == '+')  && number.Length == 0)
                number += str[i];
            else if (str[i] >= '0' && str[i] <= '9')
                number += str[i];     
            else 
                break;
        }
        double aux = 0;
        bool b = double.TryParse(number, out aux);
        if (!b) return 0;
        
        if (aux <= Int32.MinValue )
            return Int32.MinValue;
        if (aux >= Int32.MaxValue )
            return Int32.MaxValue;
        
        return (int) aux;
    }
}
