class Solution:
    
    def DFS(self, grid: List[List[int]], x, y) -> int:
    
        if grid[x][y] == 0: return 1
        if grid[x][y] == -1: return 0
        
        perimeter = 0    
        grid[x][y] = -1
        
        # check right
        if y < len(grid[x])-1: perimeter += self.DFS(grid, x, y + 1)
        else: perimeter += 1
        # check left
        if y > 0: perimeter += self.DFS(grid, x, y - 1)
        else: perimeter += 1
        # check up
        if x > 0: perimeter += self.DFS(grid, x - 1, y)
        else: perimeter += 1
        # check down
        if x < len(grid)-1: perimeter += self.DFS(grid, x + 1, y)
        else: perimeter += 1
                
        return perimeter
    
    def islandPerimeter(self, grid: List[List[int]]) -> int:
        for i in range(len(grid)):
            for j in range(len(grid[i])):
                if grid[i][j] == 1:  return self.DFS(grid, i,j)
                