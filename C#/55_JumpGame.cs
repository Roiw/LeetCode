public class Solution {
    public bool CanJump(int[] nums) {
        if (nums.Length == 1) return true;
        HashSet<int> explored = new HashSet<int>();
        Queue<int> indexes = new Queue<int>();
        indexes.Enqueue(0);
        int lastEnqueuedIndex = 0;
        while(indexes.Count > 0){
            int i = indexes.Dequeue();
            if (!explored.Add(i)) continue;
            for(int n = nums[i]; n > 0; n--){
                if (n + i == nums.Length -1)
                    return true;
                if (n + i < lastEnqueuedIndex)
                    break;
                if (n + i < nums.Length)                
                    indexes.Enqueue(n+i);   
            }
            lastEnqueuedIndex = nums[i]+i;
        }
        return false;        
    }
}
