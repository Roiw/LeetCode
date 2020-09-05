public class Solution {
    private void DFS(int k, int n, int sum, int start, List<int> current, List<IList<int>> found)
    {
        if (current.Count == k)
        {
            // We have the right length;
            if (sum == n)
                found.Add(current);
        }
        else 
        {
            for (int i = start; i <= 9; i++)
            {
                int nSum = sum;
                List<int> nCurrent = new List<int>(current);
                nCurrent.Add(i);
                nSum += i;
                DFS(k, n, nSum, i + 1, nCurrent, found);
            }
        }
    }
    public IList<IList<int>> CombinationSum3(int k, int n) {
        List<IList<int>> elems = new List<IList<int>>();
        DFS(k, n, 0, 1, new List<int>(), elems);
        return elems;
    }
}

// Version II
public class Solution {
    
    // Backtracking/DFS problem
    private List<IList<int>> _combinations = new List<IList<int>>();
    
    private void GenerateCombination(int k, int n, int start, List<int> combination){
        if (k == 0 && n == 0) {
            _combinations.Add(new List<int>(combination));
            return;
        }
        if ( n < 0  || k < 0 ) 
            return; // Pruning
        
        for (int i = start; i <= 9; i++)
        {
            combination.Add(i);
            GenerateCombination(k - 1, n - i, i+1, combination);
            combination.RemoveAt(combination.Count-1);
        }
    }
     
    public IList<IList<int>> CombinationSum3(int k, int n) {
        _combinations = new List<IList<int>>();
        GenerateCombination(k, n, 1, new List<int>());
        return _combinations;
    }
}