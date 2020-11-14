/*

    The Plan:
        - Go over time series array
            - Whenever a Poison start keep a bool variable with poison and the start time.
            - If next poison is over the 2 seconds add two seconds, otherwise add time - initial

*/

public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        bool poisoned = false;
        int poisonStart = 0;
        int timePoisoned = 0;
        
        foreach (int t in timeSeries){
            if (!poisoned) 
                poisoned = true;
            else
                timePoisoned += Math.Min(t - poisonStart, duration);        
            poisonStart = t;
        }
        
        if (poisoned)
            timePoisoned += duration;
        
        return timePoisoned;
    }
}
