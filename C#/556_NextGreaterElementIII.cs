public class Solution {
    // We want to find the next permutation in lexicographical order for the set (s).
    //
    // To do so we must:
    // 1 - Starting on the rightmost pair -> Find the first pair in which left is smaller than right.
    // 2 - We swap the found pair, and swap every other pair to it's right.
    
    
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
