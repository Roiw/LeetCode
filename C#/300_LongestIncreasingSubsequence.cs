/*  
    Dynamic Programming (Memoization)
    
        We can performa brute force and use memoization to speed things.
        For example: arr = [3, 10, 2, 11]
        
        To find the LIS of an index (INCLUSIVE), we check the LIS of all previous indexes that are smaller than the current. 
        Previous indexes that are bigger than the current don't need to be check since the resulting LIS would be 1.
        
        > The LIS for the current index is the MAX LIS from all the previous indexes, that are smaller than current, + 1.

        > The LIS including the last index is not necessary the longest! For that reason we keep a MAX variable to check the logest.
        
        Note: We can use a hashset to keep precomputed results (Memoisation)
        
        
        
    Dynamic Programming Tabulation Approach O(n²)
    
        LIS = [1,1,1,1]; Arr = [3, 10, 2, 11]
        
        Foreach element of Arr we check all the positions on LIS and increase the numbers where it increase its maximum length;
        At the end we return the biggest value in LIS.
        
         
*/

public class Solution {
    
    // Memoization.
    int max = 0;
    Dictionary<int, int> memo;
    public int Approach1(int[] arr, int index) {
        if (memo.ContainsKey(index)) return memo[index];
        
        int total = 1;
        // Finding the previous LIS starting at 0.
        for (int i = 0; i < index; i++) {
            int temp = Approach1(arr, i);
            if (arr[i] < arr[index])
                temp++;  
            else 
                temp = 1;  
            
            total = Math.Max(temp, total); // Keep track of the maximum previous LIS 
        }
        memo.Add(index, total);
        max = Math.Max(max, total);
        return total;
    }
    
    // Tabulation.
    public int Approach2(int[] arr) {
        
        int[] LIS = new int[arr.Length];
        Array.Fill(LIS, 1);
        
        for (int i = 0; i < arr.Length; i++) {
            for (int j = 0; j < i; j++)
                LIS[i] = arr[j] < arr[i]? Math.Max(LIS[i], LIS[j] + 1) : LIS[i];
        }
        
        return LIS.Max();
    }
    
    
    
    public int LengthOfLIS(int[] nums) {
        if (nums.Length == 0) return 0;
        //memo = new Dictionary<int, int>();
        //Approach1(nums, nums.Length - 1);
        return Approach2(nums);
    }
}