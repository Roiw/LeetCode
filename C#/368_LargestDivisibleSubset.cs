public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        if (nums.Length <= 1) return new List<int>(nums);
        Array.Sort(nums);
        Dictionary<int,List<int>> elements = new Dictionary<int,List<int>>();
        int max = Int32.MinValue;
        int biggestIndex = 0;
        for (int i = 0; i < nums.Length; i++) {
            elements.TryAdd(i, new List<int>());
            int most = Int32.MinValue, mostIndex = 0;
            for (int j = i-1; j >= 0; j--) {
                if (i != j && (nums[i] % nums[j] == 0 || nums[j] % nums[i] == 0)){
                    mostIndex = most < elements[j].Count? j:mostIndex;
                    most = most < elements[j].Count? elements[j].Count: most;
                }
            }
            if (most != Int32.MinValue) 
                elements[i].AddRange(elements[mostIndex]);
            elements[i].Add(nums[i]);
            if (max < elements[i].Count) {
                max = elements[i].Count;
                biggestIndex = i;
            }
        }
        if (max == Int32.MinValue) return new List<int>(){nums[0]};
        return elements[biggestIndex];
    }
}
