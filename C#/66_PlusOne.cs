public class Solution {
    public int[] PlusOne(int[] digits) {
       int carry = 0;
       int last = digits.Length -1;
        digits[last]++;
       if (digits[last] > 9) {
            carry = 1;
            digits[last] = digits[last] - 10;
       }
        
       for (int i = digits.Length - 2; i >= 0; i--) {
           digits[i] = digits[i] + carry;
           if (digits[i] > 9){
               digits[i] -= 10;
               carry = 1;
           }
           else { carry = 0; }
       }
       if (carry == 1) {
           return (new int[]{1}).Concat(digits).ToArray();
       }
        return digits;
    }
}
