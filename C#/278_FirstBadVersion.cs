/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        return BinarySearch(1,n);
    }
    
    public int BinarySearch(int start, int count) {
        
        int t = (count) / 2;
        int n = t + start;
        
        // base cases..
        bool isBad = IsBadVersion(n);
        if (isBad == true && count == 1)
            return start;
        if (isBad == true && IsBadVersion(n-1) == false)
            return n;        
        
        if (isBad)
            return BinarySearch(start, t);
        else
            return BinarySearch(n+1, t);
    }
}
