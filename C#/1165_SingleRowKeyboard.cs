public class Solution {
    public int CalculateTime(string keyboard, string word) {
        int totalTime = 0;
        Dictionary<char,int> map = new Dictionary<char,int>();
        
        // Find Indexes..
        for (int i = 0; i < keyboard.Length; i++) {
            map.Add(keyboard[i], i);
        }
        
        // First element we add by hand;
        totalTime = map[word[0]];
        
        for (int i = 0; i < word.Length-1; i++) {
            totalTime += Math.Abs(map[word[i]] - map[word[i+1]]);
        }
        return totalTime;
    }
}