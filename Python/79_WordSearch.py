class Solution:
    def exist(self, board: List[List[str]], word: str) -> bool:
        
        used = set()
        
        def DFS(row, col, index):
            if index == len(word): return True
            
            offsets = [(0,1), (0,-1), (1,0), (-1,0)]
            used.add((row, col))
            
            for o_x, o_y in offsets:
                x = o_x + row
                y = o_y + col
                if (x,y) in used: continue
                if 0 <= x < len(board) and 0 <= y < len(board[x]) and board[x][y] == word[index]:
                    if DFS(x, y, index + 1): return True
            
            used.remove((row, col))
            return False
        
        
        for row in range(len(board)):
            for col in range(len(board[row])):
                if board[row][col] == word[0] and DFS(row, col, 1):
                    return True
        
        return False
