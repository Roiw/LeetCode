/*

    WIP: 
*/

public class Solution {
    public int MinSumOfLengths(int[] arr, int target) {

        int[] nums = new int[arr.Length];
		nums = nums.Select(s => Int32.MaxValue).ToArray();
        int sum = 0, left = 0, ans = Int32.MaxValue;
		
		for (int right = 0; right < arr.Length; right++) {
			sum += arr[right];
			
			while (sum > target)
				sum -= arr[left++];
            
			if (right > 0)
				nums[right] = nums[right - 1]; 
            
			if (sum == target) {
				int dist = right - left + 1;
				if(left > 0 &&  nums[left - 1] != Int32.MaxValue)
					ans = Math.Min(ans, dist + nums[left - 1]);
                
				nums[right] = Math.Min(nums[right], dist);
			}
		}
		
		return ans == Int32.MaxValue? -1 : ans;      
    }
}
