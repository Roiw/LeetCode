public class Solution {

    private Dictionary<char, List<char>> _maps = new Dictionary<char, List<char>>();
    private List<string> _ans = new List<string>();

    public IList<string> LetterCombinations(string digits) {     
        if (digits == "") return (IList<string>) new List<string>();
        
        _maps.Add('2', new List<char>(){'a','b','c'});
        _maps.Add('3', new List<char>(){'d','e','f'});
        _maps.Add('4', new List<char>(){'g','h','i'});
        _maps.Add('5', new List<char>(){'j','k','l'});
        _maps.Add('6', new List<char>(){'m','n','o'});
        _maps.Add('7', new List<char>(){'p','q','r','s'});
        _maps.Add('8', new List<char>(){'t','u','v'});
        _maps.Add('9', new List<char>(){'w','x','y','z'});
        
        FormStrings(0, digits, "");
        
        return (IList<string>) _ans;
    }

    
    private void FormStrings (int index, string digits, string curr){
        if (index == digits.Length){
            _ans.Add(curr);
            return;
        }
        foreach (char c in _maps[digits[index]]){
            FormStrings(index + 1, digits, curr + c);
        }
    }
}
