public class Solution {
    private int[,] _used;
    public IList<string> FindWords(char[][] board, string[] words) {
        List<string> ans = new List<string>();
        if (words.Length == 0) return ans;
        
        foreach (string w in words) {
            bool found = false;
            for (int i = 0; i < board.Length; i++) {
                for (int j = 0; j < board[0].Length; j++) {            
                    if (board[i][j] == w[0]) {
                        _used = new int[board.Length, board[0].Length];
                        if (Search(board, i, j, w, 0)) {
                            ans.Add(w);  
                            found = true;
                            break;
                        }
                    }
                }
                if (found) break;
            }
        }       
        return ans;
    }
    
    // DFS..
    private bool Search(char[][] board, int x, int y, string target, int index)
    {
        if (target.Length == 1 && target[index] == board[x][y]) return true;
        if (target.Length == index) return true;
        if (_used[x,y] == 1) return false;
        if (target[index] != board[x][y]) return false;
        
        _used[x,y] = 1;
        
        // Look left..
        if (x > 0) {
            if (Search(board, x-1, y, target, index + 1))
                return true;
        }
        // Look right..
        if (x < board.Length - 1) {
            if (Search(board, x+1, y, target, index + 1))
                return true;
        }
        // Look left..
        if (y > 0) {
            if (Search(board, x, y - 1, target, index + 1))
                return true;
        }
        // Look left..
        if (y < board[0].Length - 1) {
            if (Search(board, x, y + 1, target, index + 1))
                return true;
        }
        
        _used[x,y] = 0;
        return false;
    }
}
