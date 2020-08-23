public class Solution {
    private int BinarySearch(int[] arr, int min, int max, int target, HashSet<int> selected){
        if (min > max)
            return ~min;
        int mid = min + (max - min)/2;
        if (arr[mid] == target){
            if (selected.Add(mid))
                return mid;
            else {
                // Go left or right.. 
                int rtn = BinarySearch(arr, mid + 1, max, target, selected);
                if (rtn >= 0) return rtn;
                rtn = BinarySearch(arr, min, mid - 1, target, selected);
                if (rtn >= 0) return rtn;
            }
        }
        if (arr[mid] < target)
            return BinarySearch(arr, mid + 1, max, target, selected);
        else
            return BinarySearch(arr, min, mid - 1, target, selected);
    }
    public int[] Intersect(int[] nums1, int[] nums2) {
        Array.Sort(nums1);
        List<int> ans = new List<int>();
        HashSet<int> selected  = new HashSet<int>();
        foreach (int i in nums2){
            int n = BinarySearch(nums1, 0, nums1.Length-1, i, selected);
            if (n >= 0)
                ans.Add(i);
        }
        return ans.ToArray();
    }
}
