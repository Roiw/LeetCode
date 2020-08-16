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
