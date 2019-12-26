public class Logger {
    
    public Dictionary<string, int> Logs;
    
    /** Initialize your data structure here. */
    public Logger() {
        Logs = new Dictionary<string, int>() ;
    }
    
    /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
        If this method returns false, the message will not be printed.
        The timestamp is in seconds granularity. */
    public bool ShouldPrintMessage(int timestamp, string message) {
        if (Logs.ContainsKey(message)) {
            if(timestamp - Logs[message] >=10) {
                Logs[message] = timestamp ;
                return true;
               } 
            else
                return false;
           }
        Logs.Add(message, timestamp) ;
        return true;
       
        
    }
}

/**
 * Your Logger object will be instantiated and called as such:
 * Logger obj = new Logger();
 * bool param_1 = obj.ShouldPrintMessage(timestamp,message);
 */