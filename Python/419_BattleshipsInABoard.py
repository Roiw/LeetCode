class Solution:
    def countBattleships(self, board: List[List[str]]) -> int:
        def checkBattleDirection(direction, position):
            dX, dY = direction
            x, y = position[0] + dX, position[1] + dY
            while x < len(board) and x >=0 and y < len(board[x]) and y >= 0 and board[x][y] == 'X':
                board[x][y] = '.'
                x += dX
                y += dY
                
        boats = 0
        for x in range(len(board)):
            for y in range(len(board[x])):
                if board[x][y] == 'X':
                    boats += 1
                    checkBattleDirection((0,1),(x,y))
                    checkBattleDirection((0,-1),(x,y))
                    checkBattleDirection((1, 0),(x,y))
                    checkBattleDirection((-1,0),(x,y))
                    board[x][y] = '.'
        return boats
        