public class Solution {
    public string SortString(string s) {
        
        // Sort string..bubble sort O(N^2)
        bool mod = true;
        List<char> nS = new List<char>(s);
        while (mod == true) {
            mod = false;
            for (int i = 0; i < s.Length -1; i++) {
                if (nS[i] > nS[i+1]){
                    mod = true;
                    char c = nS[i+1];
                    nS[i+1] = nS[i];
                    nS[i] = c;
                }
            }
        }
        
        // S is sorted..
        string result = ""; int j = 0;
        bool pickSmallest = true;
        while (nS.Count > 0) {
            if (pickSmallest) {
                result += nS[0]; nS.RemoveAt(0); // Step 1..
                j = 0;
                while ( j < nS.Count && result[result.Length -1] <= nS[j]) { // Step 2..
                    if (result[result.Length -1] < nS[j]) {result += nS[j]; nS.RemoveAt(j);}
                    else j++;
                }
                pickSmallest = false;
            }
            else {
                result += nS[nS.Count-1]; nS.RemoveAt(nS.Count-1); // Step 4..
                j = nS.Count-1;
                while (j >= 0 && result[result.Length-1] >= nS[j]) { // Step 5..
                    if (result[result.Length -1] > nS[j]) {result += nS[j]; nS.RemoveAt(j);}
                    j--;
                }
                pickSmallest = true;
            }
        }
        return  result;
    }
}
