public class Solution {
    private List<string> _ans = new List<string>();
    
    private void GenerateCombinations(string comb, int o, int c) {
        if (o == 0 && c == 0)
            _ans.Add(comb + "");
        
        if (o > 0) {
            comb += "(";
            GenerateCombinations(comb, o - 1, c);    
            comb = comb.Remove(comb.Length - 1);
        }
        if ( c > o  ) {
            comb += ")";
            GenerateCombinations(comb, o, c - 1);    
            comb = comb.Remove(comb.Length - 1);
        }
            
    }
    
    public IList<string> GenerateParenthesis(int n) {
        _ans = new List<string>();
        GenerateCombinations("", n, n);
        return _ans;
    }
}
