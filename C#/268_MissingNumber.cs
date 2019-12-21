public class Solution {
    public int MissingNumber(int[] nums) {

	List<int> numbers = new List<int>();

	for (int i = 0; i <= nums.Length; i++) {
	    numbers.Add(i);
    }
        
    for (int i = 0; i < nums.Length; i++) {
        numbers.Remove(nums[i]);

    }

    // At this point list only contains the answer..
    return numbers[0];
        
    }
}
