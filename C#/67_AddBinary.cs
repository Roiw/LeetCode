public class Solution {
    public string AddBinary(string a, string b) {
        bool carry = false;
        string ans = "";
        int i = a.Length - 1, j = b.Length - 1;   
        while (i >= 0 || j >= 0){
            bool aa = i >= 0 && a[i] == '1'? true:false;
            bool bb = j >= 0 && b[j] == '1'? true:false;
            ans += (aa ^ bb ^ carry)? '1' : '0';
            carry = (aa && bb) || (aa && carry) || (bb && carry);
            i--; j--;
        }
        if (carry) ans += "1";
        char[] arr = ans.ToArray();
        Array.Reverse(arr);        
        return new string(arr);
    }
}
