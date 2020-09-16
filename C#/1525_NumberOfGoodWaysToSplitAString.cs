/*

    Two Pointer (Sliding Window): O(N) S(1)
        Find Count of all Characters (Set2)
        Create Set1 which is empty
        Pointer starts in p = 0
        Loop
            decrement string[p] from set2
            Add value of string[p] to Set1 to validate that counts on set1 are the same as set2
            If true increment counter
            Move p


    Example: 'aacaba'
        'aacaba'
        p = 0       1   2   3   4   5   6
        Set1
            a       a   a   ac  ac  acb acb
        Set2 
            abc     abc abc ab  ab  a   -

    Incrementing on 3 and 4

*/

// 15 -> 25
public class Solution {
    public int NumSplits(string s) {
        
        Dictionary<char, int> Set2 = new Dictionary<char, int>();
        Dictionary<char, int> Set1 = new Dictionary<char, int>();
        
        foreach (char c in s) {
            if (!Set2.TryAdd(c, 1))
                Set2[c]++;
        }
        int count = 0;
        foreach (char c in s)  {
            if (Set2[c] == 1) Set2.Remove(c);
            else Set2[c]--;
            
            if (!Set1.TryAdd(c, 1)) Set1[c]++;
            
            if (Set1.Count == Set2.Count) count++;
        }
        
        return count;
    }
}
