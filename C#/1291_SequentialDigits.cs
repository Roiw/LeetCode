/*

    String Idea:

    "123456789"    "123456789"
     ^  ^            ^  ^

     Move pointer p1 on string to generate possible numbers. Add them to the list.
     Increase amount of digits until we reach the upper bound (high).

*/

public class Solution {

    public IList<int> SequentialDigits(int low, int high) {
        List<int> ans = new List<int>();
        string nums = "123456789";
        int digits = low.ToString().Length;
        int p1 = Int32.Parse(low.ToString()[0] + "") - 1;
        while (digits <= nums.Length ) {
            while (p1 <= nums.Length - digits) {
                // Generate number
                int n = Int32.Parse(nums.Substring(p1, digits));
                if (n <= high && n >= low) ans.Add(n);
                else if (n > high)
                    return ans;
                p1++;
            }
            digits++;
            p1 = 0;
        }
        
        return ans;    
    }
}