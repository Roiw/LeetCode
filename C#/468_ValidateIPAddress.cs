public class Solution {
    public string ValidIPAddress(string IP) {
        // Validate ipv4
        if (IP.Contains('.')){
           return ValidateIPV4(IP);
        }
        else if(IP.Contains(':')){
            return ValidateIPV6(IP);
        }
        return "Neither";
    }
    
    private string ValidateIPV4(string IP){
        string[] s = IP.Split('.');
        if (s.Length != 4) return "Neither";
        foreach (string part in s) {
            bool foundZero = false;
            if (part.Length == 0 || part.Length > 3) return "Neither";
            int result = 0;
            if (!Int32.TryParse (part, out result)) return "Neither";
            if (result > 255) return "Neither";
            if (part.Length > 1 && result == 0) return "Neither";
            for(int i = 0; i < part.Length; i++){
                foundZero = part[i] == '0'? true:foundZero;
                if (foundZero && part[i] != '0') return "Neither";
            } 
        }
        return "IPv4";
    }
    
    private string ValidateIPV6(string IP){
        string[] s = IP.Split(':');
        if (s.Length != 8) return "Neither";
        foreach (string part in s) {
            if (part.Length == 0) return "Neither";
            if (part.Length > 4) return "Neither";
            for(int i = 0; i < part.Length; i++){
                if (part[i] >= 'a' && part[i] <= 'f' || part[i] >= '0' && part[i] <= '9' ||
                   part[i] >= 'A' && part[i] <= 'F')
                    continue;
                else
                    return "Neither";
            } 
        }
        return "IPv6";
    }
}