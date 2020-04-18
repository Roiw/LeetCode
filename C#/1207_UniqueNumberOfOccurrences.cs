public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        
        Dictionary<int,int> occ = new Dictionary<int,int>();
        
        for (int i = 0; i < arr.Length; i++) {
            if (occ.ContainsKey(arr[i]))
                occ[arr[i]]++;
            else
                occ.Add(arr[i], 1);
        }
        
        HashSet<int> c = new HashSet<int>();
        foreach (KeyValuePair<int,int> kvp  in occ){
            if (!c.Add(kvp.Value))
                return false;
        }
        return true;
    }
}
