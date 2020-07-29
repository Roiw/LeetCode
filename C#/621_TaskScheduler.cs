public class Solution {

    // The idea here is to use a list to optimize tasks that need to run. 
    // We save the last time it was executed and peek it until ready to run again. 
    // After running we send it to the back of the list.
    public int LeastInterval(char[] tasks, int n) {
        // An auxiliary dictionary..
        Dictionary<char,(int,int)> taskInfo = new Dictionary<char,(int,int)>();
        foreach (char c in tasks) {
            if (!taskInfo.TryAdd(c, (1,0)))
                taskInfo[c] = (taskInfo[c].Item1 + 1, taskInfo[c].Item2);
        }
        // We will use this to itarate faster!
        Queue<(int,int)> remaining = new Queue<(int, int)>();
        foreach (var kvp in taskInfo) { 
            remaining.Enqueue(kvp.Value);
        }
            
        int clock = 0;
        while (remaining.Count > 0) {
            char found = '\0';
            if (remaining.Peek().Item2 <= clock) {
                (int quantity, int nextClock) = remaining.Dequeue();
                if (quantity > 1){
                    remaining.Enqueue((quantity - 1, nextClock + n + 1));
                }
            }
            clock++;
        }
        return clock;
    }
}
