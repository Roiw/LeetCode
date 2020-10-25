public class Solution {
    public char SlowestKey(int[] releaseTimes, string keysPressed) {
        List<char> maxPressed = new List<char>(){keysPressed[0]};
        int max = releaseTimes[0];
        
        for (int i = 1; i < releaseTimes.Length; i++) {
            int curr = releaseTimes[i] - releaseTimes[i - 1];
            
            if (curr == max)
                maxPressed.Add(keysPressed[i]);
            if (max < curr) {
                maxPressed.Clear();
                maxPressed.Add(keysPressed[i]);
                max = curr;
            }
        }
        
        maxPressed.Sort();
        return maxPressed[maxPressed.Count - 1];
    }
}
