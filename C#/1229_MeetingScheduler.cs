/*
    Brute force solution O(N²)
*/

public class Solution {
    
    public IList<int> MinAvailableDuration(int[][] slots1, int[][] slots2, int duration) { 
        
        List<int[]> valid = new List<int[]>();
        
        foreach (int[] s1 in slots1){
            foreach (int[] s2 in slots2) {
                int start = Math.Max(s1[0], s2[0]);
                int end = Math.Min(s1[1], s2[1]);
                if (end - start >= duration)
                    valid.Add(new int[] {start, start + duration});
            }
        }
        int min = Int32.MaxValue;    
        List<int> ans =  new List<int>();
        
        foreach (var v in valid){
            if (v[0] < min){
                ans = new List<int>(){v[0],v[1]};
                min = v[0];
            }
        }
        return ans;
    }     
}

/*
    TODO: Two Pointer solution O(N Log N)

        Sort both lists. 
        Foreach element of List A
            Find index of closest start on list B

*/