public class TimeMap {

    private Dictionary<string, List<(int,string)>> _map;
    
    /** Initialize your data structure here. */
    public TimeMap() {
        _map = new Dictionary<string, List<(int,string)>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!_map.ContainsKey(key)) 
            _map.Add(key, new List<(int,string)>());
        
        _map[key].Add((timestamp, value)); // Add element in a sorted way
           
    }
    
    public string Get(string key, int timestamp) {
        
        if (!_map.ContainsKey(key))
            return "";
        else {
            
            // check if there is a key
           return FindBinarySearch(timestamp, _map[key], 0, _map[key].Count);
        }       
    }
    
    private string FindBinarySearch(int target, List<(int,string)> list, int start, int end){
        if (end-start == 1){
             var (k, v) = list[start];
            if (k <= target)
                return v;
            else 
                return "";
        }
        
        int mid = start + (end - start)/2;
        var (key, value) = list[mid]; 
        if (key <= target){
            var rsl = FindBinarySearch(target, list, mid, end);  
            if (rsl == "")
                return value;
            else
                return rsl;                     
        }
        else { 
            return FindBinarySearch(target, list, start, mid);   
            
        }   
    }
}

/**
 * Your TimeMap object will be instantiated and called as such:
 * TimeMap obj = new TimeMap();
 * obj.Set(key,value,timestamp);
 * string param_2 = obj.Get(key,timestamp);
 */