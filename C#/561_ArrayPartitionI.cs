public class Solution {
    public int ArrayPairSum(int[] nums) {
        
        List<int> arr = new List<int>(nums);
        List<int> sorted = Sort(arr);
        int sum = 0;
        for (int i = 0; i < sorted.Count; i = i + 2) {
            sum += Math.Min(sorted[i], sorted[i+1]);
        }
        return sum;    
    }
    
    public List<int> Sort(List<int> unsorted) {
            if (unsorted.Count == 1)
                return unsorted;
            
            // Fix for odd numbers.
            int increment = 0;
            if (unsorted.Count % 2 != 0)
                increment = 1;

            List<int> left = unsorted.GetRange(0, unsorted.Count / 2);
            List<int> right = unsorted.GetRange(unsorted.Count / 2, (unsorted.Count / 2) + increment);

            left = Sort(left);
            right = Sort(right);
           
           return Merge(left, right);
        }

        public List<int> Merge(List<int> left, List<int> right) {
            int leftIndex = 0;
            int rightIndex = 0;
            List<int> ans = new List<int>();

            while( leftIndex < left.Count || rightIndex < right.Count) {
                if (leftIndex < left.Count && rightIndex < right.Count ) {
                    if (right[rightIndex] < left[leftIndex]) {
                        ans.Add(right[rightIndex]);
                        rightIndex++;
                    }                    
                    else {
                        ans.Add(left[leftIndex]);
                        leftIndex++;
                    }                     
                }
                else if (leftIndex < left.Count) {
                    ans.Add(left[leftIndex]);
                    leftIndex++;
                }
                else if (rightIndex < right.Count) {
                    ans.Add(right[rightIndex]);
                    rightIndex++;
                }
            }
            return ans;
        }  
}