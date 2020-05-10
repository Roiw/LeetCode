public class Solution {
    public int FindJudge(int N, int[][] trust) {
        
        if (N == 1 && trust.Length == 0) return 1;
        
        Dictionary<int,int> people = new Dictionary<int,int>();
        HashSet<int> whoTrust = new HashSet<int>();
        
        int max = -1;
        int maxElem = -1;
        foreach(int[] pair in trust){
            if (!people.ContainsKey(pair[1]))
                people.Add(pair[1], 0);
            
            people[pair[1]]++;
            
            if (people[pair[1]] > max){
                max = people[pair[1]];
                maxElem = pair[1];
            }
            
            whoTrust.Add(pair[0]);
        }
        
        // Everybody trusts someone..
        if (whoTrust.Count == N)
            return -1;
        
        if (max == N-1)
            return maxElem;

        return -1;
    }
}
