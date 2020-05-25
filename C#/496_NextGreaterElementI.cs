public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int[] ans = new int[nums1.Length];
        Dictionary<int,int> indexes = new Dictionary<int,int>();
        for (int i = 0; i < nums2.Length; i++){
            indexes.Add(nums2[i], i);
        }
        for (int i = 0; i < nums1.Length; i++){
            ans[i] = -1;
            int k = indexes[nums1[i]];
            for (int j = k; j < nums2.Length; j++){
                if (nums2[j] > nums1[i]){
                    ans[i] = nums2[j];
                    break;
                }
            }
        }
        return ans;
    }
}
