public class Solution {
    public int FindMaxLength(int[] nums) {
        if (nums.Length == 0) return 0;
        if (nums.Length == 1) return 0;
        
        int maxFound = 0;
        Dictionary<int,int> dic = new Dictionary<int,int>();
        dic.Add(0,0);
        int result = 0;
        for (int i = 0; i < nums.Length; i++) {            
            result = nums[i] == 1 ? result + 1 : result - 1;
            if(dic.ContainsKey(result)) {
                int len = (i+1) - dic[result];
                maxFound = maxFound < len ? len : maxFound;
            }else
                dic.Add(result, i+1);
        }
        return maxFound;
    }
}
