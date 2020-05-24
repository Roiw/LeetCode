// A lot o people like to use a priority queue, or heap here.
// Since K is always smaller than the size of the input array. We can use similar structure to save our frequency data.
// The insertion is O(1) in this case.

public class Solution {
    
    // k is always valid!
    public int[] TopKFrequent(int[] nums, int k) {
        List<int>[] freqArray = new List<int>[nums.Length];     
        Dictionary<int, int> freqs = new Dictionary<int,int>();
        int[] ans = new int[k];
        
        // All frequencies..
        for (int i = 0; i < nums.Length; i++){
            if (!freqs.TryAdd(nums[i], 1))
                freqs[nums[i]]++;
        }
        
        // Populate frequency array
        foreach (KeyValuePair<int,int> f in freqs){
            if (freqArray[f.Value-1] == null) freqArray[f.Value-1] = new List<int>();
            freqArray[f.Value-1].Add(f.Key); 
        }
        
        int j = 0;
        // Get the most frequent
        for (int i = nums.Length -1; i >= 0; i--){
            if (freqArray[i] != null){
                foreach (int e in freqArray[i]){
                    ans[j] = e;
                    j++;
                    if (j == k) return ans;
                }
            }
        }
        return ans;
    }
}
