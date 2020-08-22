public class Solution {
    public bool BinarySearch(int[] arr, int min, int max, int target){
        if (min > max)
            return false;
        int mid = min + (max - min)/2;
        if (arr[mid] == target)
            return true;
        if (arr[mid] < target)
            return BinarySearch(arr, mid + 1, max, target);
        else
            return BinarySearch(arr, min, mid - 1, target);
    }
    public int[] Intersection(int[] nums1, int[] nums2) {
        if(nums1.Length == 0 || nums2.Length == 0)
            return new int[0];
        Array.Sort(nums1);
        HashSet<int> ans = new HashSet<int>();
        HashSet<int> searched = new HashSet<int>();
        foreach (int i in nums2){
            if (searched.Contains(i)) continue;
            if (BinarySearch(nums1, 0, nums1.Length - 1, i))
                ans.Add(i);
            searched.Add(i);
        }
        return ans.ToArray();
    }
}
