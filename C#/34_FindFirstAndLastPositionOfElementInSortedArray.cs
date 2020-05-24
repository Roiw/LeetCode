public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length == 0) return new int[] {-1,-1};
        int lower = LowerBound(nums, target, 0, nums.Length);
        int upper = UpperBound(nums, target, 0, nums.Length);
        return new int[]{lower, upper};
    }
    
	private static int UpperBound(int[] nums, int target, int start, int len)
	{
		int mid = len / 2;
		int i = mid + start;
        if (nums.Length == 1) return nums[0] == target? 0 : -1;
        if (len == 0) return -1;
		if (i == nums.Length - 1){
			if (nums[i] == target) return i;
			else if (nums[i-1] == target) return i-1;
			else return -1;
		}
		if (i < 1)
			return nums[i] == target ? i : -1;
		if (nums[i] < target)
			return UpperBound(nums, target, i + 1, nums.Length - i - 1); // Advance right
		if (nums[i] == target)
		{
			if (nums[i + 1] != target)
				return i;
			else
				return UpperBound(nums, target, i + 1, nums.Length - i - 1); // Advance right
		}
		else
			return UpperBound(nums, target, start, len / 2); // Advance to the left..
	}

	private static int LowerBound(int[] nums, int target, int start, int len)
	{
		int mid = len / 2;
		int i = mid + start;
        if (nums.Length == 1) return nums[0] == target? 0 : -1;
        if (len == 0) return -1;
		if (i > nums.Length - 1)
			return nums[i-1] == target ? i-1 : -1;
		if (i < 1)
			return nums[i] == target ? i : -1;
		if (nums[i] < target)
			return LowerBound(nums, target, i + 1, nums.Length - i - 1); // Advance to right..
		if (nums[i] == target)
		{
			if (nums[i - 1] != target)
				return i;
			else
				return LowerBound(nums, target, start, len / 2); // Advance to left..
		}
		else
			return LowerBound(nums, target, start, len / 2); // Advance to left
	}

}
