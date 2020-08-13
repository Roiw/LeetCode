public class Solution {
    public string[] FindRelativeRanks(int[] nums) {
        SortedList<int,int> sorted = new SortedList<int,int>();
        for(int i = 0; i < nums.Length; i++) {
            sorted.Add(nums[i], i);
        }
        string[] ans = new string[nums.Length];
        int n = ans.Length;
        foreach (var athlete in sorted) {
            ans[athlete.Value] = n.ToString();
            n--;
        }
        ans[sorted.Values[nums.Length - 1]] = "Gold Medal";
        if (ans.Length == 1) return ans;
        ans[sorted.Values[nums.Length - 2]] = "Silver Medal";
        if (ans.Length == 2) return ans;
        ans[sorted.Values[nums.Length - 3]] = "Bronze Medal";
        return ans;
    }
}
