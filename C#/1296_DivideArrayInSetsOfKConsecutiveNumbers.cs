public class Solution {
    public bool IsPossibleDivide(int[] nums, int k) {
        if (nums.Length % k != 0)
            return false;

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == -1) continue;
            int count = 1;
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] == -1) continue;

                if (nums[i] + 1 == nums[j])
                {
                    count ++; // increase the count of elements on the group..
                    nums[i] = nums[j]; // Continue from j
                    nums[j] = -1; // Mark off..
                }
                if (count == k) break; // groups completed.. break
            }
            // Done searching for groups element for nums[i]
            if (count < k) return false; // Could not find a group.
        }
        return true;
    }
}