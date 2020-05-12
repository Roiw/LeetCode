public class Solution {
    public IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king) {
        
        HashSet<(int,int)> queenPositions = new HashSet<(int,int)>();
        List<IList<int>> found = new List<IList<int>>();
        
       for (int i = 0; i < queens.Length; i++){
            queenPositions.Add((queens[i][0], queens[i][1]));
        }
        
        // Navigate North
        for (int i = king[0]; i >= 0; i--){
            if (queenPositions.Contains((i,king[1]))) {
                found.Add(new List<int>(){i, king[1]});
                break;
            }
        }
           
        // Navigate South
        for (int i = king[0]; i < 8; i++){
            if (queenPositions.Contains((i,king[1]))){
                found.Add(new List<int>(){i,king[1]});
                break;
            }
        }
        
        // Navigate East
        for (int i = king[1]; i < 8; i++){
            if (queenPositions.Contains((king[0],i))){
                found.Add(new List<int>(){king[0],i});
                break;
            }
        }
        
        // Navigate West
        for (int i = king[1]; i >= 0; i--){
            if (queenPositions.Contains((king[0],i))){
                found.Add(new List<int>(){king[0],i});
                break;  
            } 
        }
        
        // Navigate Southeast 
        for (int i = 1; king[0] + i < 8 && king[1] + i < 8; i++){
            if (queenPositions.Contains((king[0] + i, king[1] + i))){
                found.Add(new List<int>(){king[0] + i, king[1] + i});
                break;  
            } 
        }
        
        
        // Navigate Northeast
        for (int i = 1; king[0] - i >= 0 && king[1] + i < 8; i++){
            if (queenPositions.Contains((king[0] - i, king[1] + i))){
                found.Add(new List<int>(){king[0] - i, king[1] + i});
                break;  
            } 
        }
        
        // Navigate Southwest
        for (int i = 1; king[0] + i < 8 && king[1] - i >= 0; i++){
            if (queenPositions.Contains((king[0] + i, king[1] - i))){
                found.Add(new List<int>(){king[0] + i, king[1] - i});
                break;  
            } 
        }
    
        
        
        // Navigate Northwest
        for (int i = 1; king[0] - i >= 0 && king[1] - i >= 0; i++){
            if (queenPositions.Contains((king[0] - i, king[1] - i))){
                found.Add(new List<int>(){king[0] - i, king[1] - i});
                break;  
            } 
        }
    
        return found ;
    }

}
