/* Intuition behind 

   First and foremost: 
      (0 + K) % K = 0
      (4 + K) % K = 4
      (4 + 2K) % K = 4
      So whenever you add a multiple of the K the result is the remaining you had initially.  

   Knowing that, you can sum the array element by element and for each addition record the remaining 
   of the % opeartion with K. If you see a result a second time it means we summed a subsequence that
   adds to a multiple of K.

   okay.. this should be cleaned up.. it riddled with edge cases. Kudo for the creator of test cases here..
*/
public class Solution 
{
    public bool CheckSubarraySum(int[] nums, int k) 
    {
        if (nums.Length < 2) return false;

        Dictionary<int, int> seen = new();
        int sum = nums[0];
        seen.Add(sum % k, -1); // edge case..
        for (int i = 1; i < nums.Length; i++)//[5:-1, 5:1]
        {
            sum += nums[i];
            int remaining = sum % k;
            if (nums[i] == 0)
            {
                if (nums[i - 1] == 0) return true;
                continue;
            }
            if (nums[i] == k && nums[i-1] == 0) return true;
            if (remaining == 0) return true;
            if (seen.TryGetValue(remaining, out int index) ) 
            {
                if (i - index >= 2 && nums[i] != k) return true;
            }
            else
            {
                seen.Add(remaining, i);
            }
        } 
        return false;
    }
}