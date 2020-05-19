public class Solution {
    public IList<int> PathInZigZagTree(int label) {
        // row 0 = 1
        // row 1 = 2
        // row 2 = 4
        // row 3 = 8 
        // row 4 = 16
        // odd numbered starts with -> even
        
        int l = label;
        List<int> aux = new List<int>();
        aux.Add(l);
        while (l > 1){
            l = CalculateParent((double)l);
            l = l < 1? 1 : l;
            aux.Insert(0,l);        
        }

        return aux;
    }
    
    private int CalculateParent(double label){
        
        double d = Math.Log(label, 2);     
        double starting = Math.Pow(2,Math.Floor(d));
        
        double diff = label - starting;
        double diff2 = diff/2;
        
        int ans = (int)(starting - Math.Floor(diff2) - 1);
        return ans;
    }
}
