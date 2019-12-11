public class Solution {
        public List<KeyValuePair<int,int>> FindPath(int index, int k, int[] stones) {
        List<KeyValuePair<int,int>> findings = new List<KeyValuePair<int,int>>();
        
        // Finding for all k's
        for (int j = -1; j < 2; j ++ ) {
            if (stones[index] < stones[index] + k + j) {
                int landing = stones[index] + k + j; 
                for (int i = index; i < stones.Length; i++ ) {
                    if (stones[i] == landing) {
                        findings.Add(new KeyValuePair<int,int>(i, k + j));
                    }
                    if (stones[i] > landing) // means the landing is water..
                        break;
                }
            }
        }       
        return findings;
    }
    
    public bool CanCross(int[] stones) {
        
        if (stones[1] != 1)
            return false;
        
        int target = stones.Length - 1;
        Stack<KeyValuePair<int,int>> toCheck = new Stack<KeyValuePair<int,int>>();
        HashSet<KeyValuePair<int,int>> alreadyChecked = new HashSet<KeyValuePair<int,int>>();
        
        toCheck.Push(new KeyValuePair<int,int>(1,1));
        
        while(toCheck.Count > 0) {
            KeyValuePair<int,int> current = toCheck.Pop();
            // Check if we are on the last stone..
            if (current.Key == target)
                return true;
            
            // Figure out the next path..
            List<KeyValuePair<int,int>> nextPaths = FindPath(current.Key, current.Value, stones);
            foreach (KeyValuePair<int,int> path in nextPaths) {
                // I only check if this path wasnt already checked..
                if (alreadyChecked.Add(path))
                    toCheck.Push(new KeyValuePair<int,int> (path.Key, path.Value));
            }
        }
        
        // Could not find any path.
        return false;
    }
}
