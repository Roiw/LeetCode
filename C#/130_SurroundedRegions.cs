public class Solution {
    public void Solve(char[][] board) {
        // Identify elements that need to be changed.
        for (int i = 0; i < board.Length; i++){
            Queue<int[]> bfs = new Queue<int[]>(); 
            if (i == 0 || i == board.Length - 1) {
                for (int j = 0; j < board[i].Length; j++) {
                    if (board[i][j] == 'O')  
                        bfs.Enqueue(new int[2]{i,j});
                }
            }
            else {
                if (board[i][0] == 'O')  bfs.Enqueue(new int[2]{i,0}); 
                if (board[i][board[i].Length-1] == 'O')  bfs.Enqueue(new int[2]{i, board[i].Length-1});
            }
            
            // Do the BFS on the borders to identify elements...
            while (bfs.Count > 0) {
                int[] p = bfs.Dequeue();
                int a = p[0], b = p[1];
                board[a][b] = 'K';
                if (a - 1 > 0 && board[a-1][b] == 'O') bfs.Enqueue(new int[2]{a-1,b});
                if (b - 1 > 0 && board[a][b-1] == 'O') bfs.Enqueue(new int[2]{a,b-1});
                if (a + 1 < board.Length - 1 && board[a+1][b] == 'O') bfs.Enqueue(new int[2]{a+1,b});
                if (b + 1 < board[a].Length - 1 && board[a][b+1] == 'O') bfs.Enqueue(new int[2]{a,b+1});
            }
        }
        // Fix the table
        for (int i = 0; i < board.Length; i++){
            for (int j = 0; j < board[i].Length; j++){
                board[i][j] = board[i][j] == 'O'? 'X' : board[i][j];
                board[i][j] = board[i][j] == 'K'? 'O' : board[i][j];
            }
        }
    }
}