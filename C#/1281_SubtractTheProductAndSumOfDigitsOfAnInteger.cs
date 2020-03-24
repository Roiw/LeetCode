public class Solution {
    public int SubtractProductAndSum(int n) {
        int k, sum = 0;
        string i = n.ToString();
        int mul = 1;
        while(true) {
            i = IsolateNumber(i, out k);           
            sum += k;
            mul *= k;
            if (i == null)
               break; // End of number..
        }
        return mul-sum;
    }
    
    public string IsolateNumber(string n, out int k) {
        k = Int32.Parse("" + n[0]);
        n = n.Remove(0,1); // Remove starting at index 0, 1 element.
        if (n.Length == 0)
            return null;
        else {
            return n;
        }
    }
}
