public class Solution {
    public int OrangesRotting(int[][] grid) {

        /*
        #Step 1:
            1- Run through matrix
            2- for every rotten orange-> add to a queue
            3- Count number of good oranges.

        #Step 2:
            1 - While there iis oranges on the queue
                make all its neighbors rotten, 
                add them to queue.
                increase minutes counter. (x, y, m)
                
            2- Check if we rotten all the oranges, otherwise return -1
        */
        
        // Idenfying rotten oranges..
      
        int[][] direction = new int[4][] { 
            new int[2] {-1, 0}, 
            new int[2] {1, 0},
            new int[2] {0, 1}, 
            new int[2] {0, -1} };
        
        Queue<(int x, int y, int m)> queue = new Queue<(int, int, int)>();
        int goodOranges = 0;

        // STEP 1: Adding bad oranges to queue and counting good ones.
        for (int i = 0; i < grid.Length; i++){
          for (int j = 0; j < grid[i].Length; j++) {
            if (grid[i][j] == 2)
              queue.Enqueue((i, j, 0));
            if (grid[i][j] == 1)
              goodOranges++;
          }
        }

        int minutes = 0;

        // STEP 2
        while (queue.Count > 0) {

          var orange = queue.Dequeue();
          minutes = minutes < orange.m ? orange.m : minutes;

          // Turn all its neighbors bad.
          foreach (int[] dir in direction) {
            (int x, int y, int m) = orange;
            x += dir[0];
            y += dir[1];
            if (x >= 0 && x < grid.Length && y >= 0 &&  y < grid[x].Length) {
              if (grid[x][y] == 1){
                queue.Enqueue((x, y, m + 1));
                grid[x][y] = 2;
                goodOranges--;  
              }
            }
          }
        }

        return goodOranges > 0? -1 : minutes;
    }
}