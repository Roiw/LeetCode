public class Solution {
    
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        
        // Optimization
        if(image[sr][sc] == newColor) return image;
        
        //BFS
        Queue<(int,int)> _toCheck = new Queue<(int,int)>();
        HashSet<(int,int)> _alreadyAdded = new HashSet<(int,int)>();
        
        _toCheck.Enqueue((sr,sc));
        
        while (_toCheck.Count > 0){
            
            (int r, int c) = _toCheck.Dequeue();
            
            // Add top
            if (r > 0 && image[r-1][c] == image[r][c] 
                && _alreadyAdded.Add((r-1,c)) ){
                _toCheck.Enqueue((r-1,c));
            }
            
            // Add left          
            if (c > 0 && image[r][c-1] == image[r][c] 
                && _alreadyAdded.Add((r,c-1))){
                _toCheck.Enqueue((r,c-1));
            }
            
            // Add right
            if (c < image[r].Length-1 && image[r][c+1] == image[r][c] 
                && _alreadyAdded.Add((r,c+1))){
                _toCheck.Enqueue((r,c+1));
            }
            
            // Add bottom
            if (r < image.Length-1 && image[r+1][c] == image[r][c] 
                && _alreadyAdded.Add((r+1,c))){
                _toCheck.Enqueue((r+1,c));
            }
            
            image[r][c] = newColor;
        }
        
        return image;
    }
}
