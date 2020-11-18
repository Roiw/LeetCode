/*
    The Plan:
        - Split version strings by '.'
        - Starting on the first element of the split
            Convert to int
            Compare
                if equal continue;
                else return answer
            if one of version arrays reaches the end.
                check every element to see if there is an x != 0
                if true then the element is bigger.
*/

public class Solution {
    public int CompareVersion(string version1, string version2) {
      
        string[] v1 = version1.Split(".");
        string[] v2 = version2.Split(".");
        
        int p1 = 0;
        int p2 = 0;
        
        while ( p1 < v1.Length || p2 < v2.Length) {
            int n1 = Int32.Parse(p1 < v1.Length? v1[p1] : "0");
            int n2 = Int32.Parse(p2 < v2.Length? v2[p2] : "0");
            
            if (n1 > n2)
                return 1;
            if (n1 < n2)
                return -1;
            p1++;
            p2++;
        }
        return 0;
    }
}
