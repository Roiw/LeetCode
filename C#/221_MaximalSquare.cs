public class Solution {  
    private int _biggest = 0;
    
    public int MaximalSquare(char[][] matrix) {
        for (int i = 0; i < matrix.Length; i++){
            for (int j = 0; j < matrix[i].Length; j++){
                if (matrix[i][j] == '1' && CheckValid(matrix,i,j)){
                    int n = _biggest > 0 ? _biggest : 1;
                    // Optimization: Check Inwards.. starting to check considering 
                    // this element lead us to a square as big as our max square
                    // is a way to quickly discard this element 
                    while (n > 0)  
                        n = Validate(matrix,i,j,n) - 1;
                    
                    if (n < 0) continue; // Check element desnt check inwards..
                    n = _biggest > 0 ? _biggest : 1;
                    // Check outwards..
                    while (n > 0){
                        n = Validate(matrix,i,j,n);
                        _biggest = n > _biggest? n : _biggest;
                        n++;
                    }
                }
                if (matrix[i][j] == '1' && _biggest == 0) _biggest = 1;
            }
        }
        return _biggest * _biggest;
    }
    
    private int Validate(char[][] m, int iI, int jJ, int n){
        // Horizontal..
        for (int j = 0; j < n; j++){     
            int b = j+jJ; 
            int k = iI + n - 1;
            if (k >= m.Length || b >= m[k].Length || m[k][b] != '1')
                return -1;
        }
        // Vertical
        for (int i = 0; i < n; i++) {
            int a = i+iI;
            int k = jJ + n - 1;
            if (a >= m.Length || k >= m[a].Length ||  m[a][k] != '1')
                return -1;         
        }
        return n;
    }
    
    // Optimization: Check if I should search from this element.
    private bool CheckValid(char[][] matrix, int i, int j ){
        if (matrix.Length == 1 && matrix[0].Length == 1 && matrix[0][0] == '1') return true;
        
        if (j < matrix[i].Length -1 && i < matrix.Length -1) {
            if (matrix[i][j+1] == '1' && matrix[i+1][j] == '1')
                return true; // Right bottom..
        }
        if (j < matrix[i].Length -1 && i > 0) {
            if (matrix[i][j+1] == '1' && matrix[i-1][j] == '1')
                return true; // Right up..
        }
        if (j > 0 && i < matrix.Length -1) {
            if (matrix[i][j-1] == '1' && matrix[i+1][j] == '1')
                return true; // Left bottom..
        }
        if (j > 0 && i > 0) {
            if (matrix[i][j-1] == '1' && matrix[i-1][j] == '1')
                return true; // Left up..
        }
        return false;
    }
}
