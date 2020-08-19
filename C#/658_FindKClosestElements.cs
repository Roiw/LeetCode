public class Solution {
    private int BinSearch(int[] arr, int min, int max, int k, int target) {
        if (min >= max)
            return min;
        int mid = min + (max-min)/2;
        
        // Go right
        if (target - arr[mid] > arr[mid + k] - target)
            return BinSearch(arr, mid + 1, max, k, target);
        // Go left
        else
            return BinSearch(arr, min, mid, k, target);
        
    }
    public IList<int> FindClosestElements(int[] arr, int k, int x) {
        int start = BinSearch(arr, 0, arr.Length - k, k, x);
        List<int> elems = new List<int>();
        
        for (int i = start; i < start+k; i++)
            elems.Add(arr[i]);
        
        return elems;
    }
}
