public class Solution {
    public string GetHint(string secret, string guess) {
        
        int countA = 0;
        int countB = 0;
        
        Dictionary<char,int> notFoundSecret = new Dictionary<char,int>();
        Dictionary<char,int> notFoundGuess = new Dictionary<char,int>();
        
        for (int i = 0; i < secret.Length; i++ ) {
           
            if (secret[i].Equals(guess[i])) {
                countA++;
                continue;
            }
            
            
            if (notFoundSecret.ContainsKey(guess[i])) {
                countB++;
                notFoundSecret[guess[i]]--;
                if (notFoundSecret[guess[i]] == 0)
                    notFoundSecret.Remove(guess[i]);
            }
            else if (notFoundGuess.ContainsKey(guess[i])) 
                    notFoundGuess[guess[i]] ++;
            else
                    notFoundGuess.Add(guess[i], 1);
            
            if (notFoundGuess.ContainsKey(secret[i])) {
                countB++;
                notFoundGuess[secret[i]] --;
                if (notFoundGuess[secret[i]] == 0)
                    notFoundGuess.Remove(secret[i]);
            }
            else if (notFoundSecret.ContainsKey(secret[i]) ){
                notFoundSecret[secret[i]] ++;
            } else
                notFoundSecret.Add(secret[i],1);
            
            
        }
        return countA.ToString() + "A" + countB.ToString() + "B";
    }
}