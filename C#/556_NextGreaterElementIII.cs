public class Solution {
    // We want to find the next permutation in lexicographical order for the set (s).
    //
    // To do so we must:
    // 1  - Iterate on the array using two loops (A,B) 
    // 2  - For every A we will find the first position B, starting from the rightmost and ending on A, that is greater than A. 
    // 3a - If don't find any position after searching all A's we are at the end of the permutation set. (eg: start:[123] end:[321] )
    // 3b - If we found a position we swap A and B and all elements right of A (A+1 and so forward).
    // At the end we have the Next permutation.
    
    public int NextGreaterElement(int n) {
        char[] s = n.ToString().ToCharArray();
        int ans = -1;
        for (int i = s.Length-2; i >= 0; i--){
            for (int j = s.Length-1; j >= i; j--) {
                if (s[i] < s[j]){
                    Swap(s, i, j);
                    i++;
                    int k = s.Length - 1;
                    while (i < k){
                        Swap(s, i, k);
                        i++;
                        k--;
                    }
                    // Finished one exchange..
                    return Int32.TryParse(s, out ans) ? ans : -1;
                }
            }
        }
        
        return ans;
    }
    
    private void Swap(char[] n, int a, int b){
        if (a == b)
            return;
        
        char t = n[a];
        n[a] = n[b];
        n[b] = t;
    }
}
