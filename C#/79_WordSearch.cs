public class Solution {
    // 10:52
    public bool Exist(char[][] board, string word) {
        for (int i = 0; i < board.Length; i++){
            for (int j = 0; j < board[i].Length; j++){
                if (board[i][j] != word[0]) continue;
                if (Check(board, word, 0, (i,j), new HashSet<(int,int)>()))
                    return true;
            }
        }
        return false;
    }
    
    private bool Check(char[][] board, string w, int index, (int,int) start, HashSet<(int,int)> used) {
        used.Add(start);
        (int x, int y) = start;
        if (index == w.Length - 1)
            return true;
        
        bool foundPath = false;
        
        // Check top..
        if (x > 0 && w[index+1] == board[x-1][y] && !used.Contains((x-1,y))) {
            foundPath = Check(board, w,  index + 1, (x-1,y), used);
            if (foundPath) return true;
            used.Remove((x-1,y));
        }
        // Check bottom..
        if (x < board.Length-1 && w[index+1] == board[x+1][y] && !used.Contains((x+1,y))) {
            foundPath = Check(board, w, index + 1, (x+1,y), used);
            if (foundPath) return true;
            used.Remove((x+1,y));
        }
            
        // Check left..
        if (y > 0 && w[index+1] == board[x][y-1] && !used.Contains((x,y-1))) {
            foundPath = Check(board, w, index + 1, (x,y-1), used);
            if (foundPath) return true;
            used.Remove((x,y-1));
        }
        
        // Check right..
        if (y < board[x].Length-1 && w[index+1] == board[x][y+1] && !used.Contains((x,y+1))) {
            foundPath = Check(board, w, index + 1, (x,y+1), used);
            if (foundPath) return true;
            used.Remove((x,y+1));
        }
        return false;
    }
}
