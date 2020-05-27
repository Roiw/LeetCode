public class Solution {
    // This is a "Minimum Stack" kind of exercise
    // We will keep a stack with all the elements that are smaller than our pivot (lastDepth)
    public int Trap(int[] height) {
        Stack<int> traps = new Stack<int>();
        int lastDepth = 0;
        int trapped = 0;
        for (int i = 0; i < height.Length; i++){
            if (height[i] >= lastDepth){
                while (traps.Count > 0){
                    int t = traps.Pop();
                    trapped += lastDepth - t;
                }
                lastDepth = height[i];
            }
            else
                traps.Push(height[i]);
        }
        
        // the rest
        lastDepth = 0;
        while (traps.Count > 0){
            int t = traps.Pop();
            if (lastDepth == 0 && t == 0)
                continue;   
            if (t >= lastDepth)
                lastDepth = t;
            else
                trapped += lastDepth - t;
        }
        
        return trapped;
    }
}
