public class Solution {
    public void Rotate(int[] nums, int k) {     
        
        if (k == nums.Length)
            return;
        
        int newK = k > nums.Length ? k % nums.Length : k;
        
        int[] arr = Reverse(nums, 0, nums.Length-1);
        
        arr = Reverse(arr, 0, newK -1);
        arr = Reverse(arr, newK, nums.Length-1);
        
        for (int i =0; i< arr.Length; i++){
            nums[i] = arr[i];
        }
        
    }
    
    public int[] Reverse(int[] array, int start, int end) {
        
        while(start < end) {
            int aux = array[start];
            array[start] = array[end];
            array[end] = aux;
            start ++ ;
            end --;
        }
       
        return array;
        
    }
        
}