public class Solution {
    // My idea here is: 
    //   1 - Add the first dislike pair to their groups.
    //   2 - Based on the first pair, add all following pairs that have a member beloing to one of the groups. 
    //  For example if we started with a pair (1,2) and later we found (2,5) we know that 5 should go with 1.
    //   3 - In just one pass we can't guarantee that all elements are added. So we repeat the proccess.
    //   4 - If in a pass we didn't add any element than we add an element to the groups. 
    // (This happens if there are elements completely unrelated to the ones in the group; eg: (1,2),(3,4),(3,5). (1,2) is unrelated.
    //   5 - If during the process we didn't get into any 'conflict', the groups can be partitioned.
    public bool PossibleBipartition(int N, int[][] dislikes) {
        if (N == 1) return true;
        Queue<(int,int)> notFoundYet = new Queue<(int,int)>();
        HashSet<int> group1 = new HashSet<int>();
        HashSet<int> group2 = new HashSet<int>();
        group1.Add(dislikes[0][0]);
        group2.Add(dislikes[0][1]);
        foreach (int[] g in dislikes) {       
            if (group1.Contains(g[0])) group2.Add(g[1]);
            else if (group2.Contains(g[0])) group1.Add(g[1]);
            else if (group1.Contains(g[1])) group2.Add(g[0]);
            else if (group2.Contains(g[1])) group1.Add(g[0]);
            else
                notFoundYet.Enqueue((g[0],g[1]));
            // Check if violates rules conditions..
            if (group1.Contains(g[0]) && group1.Contains(g[1])) return false;
            else if (group2.Contains(g[0]) && group2.Contains(g[1])) return false;
        }
        int check = 0;
        int amount = notFoundYet.Count;
        while (notFoundYet.Count > 0){
            (int a, int b) = notFoundYet.Dequeue();
            if (group1.Contains(a) && group1.Contains(b)) return false;
            else if (group2.Contains(a) && group2.Contains(b)) return false;
            else if (group1.Contains(a)){ group2.Add(b); check = 0; amount = notFoundYet.Count;}
            else if (group1.Contains(b)){ group2.Add(a); check = 0; amount = notFoundYet.Count;}
            else if (group2.Contains(a)){ group1.Add(b); check = 0; amount = notFoundYet.Count;}
            else if (group2.Contains(b)){ group1.Add(a); check = 0; amount = notFoundYet.Count;}      
            else notFoundYet.Enqueue((a,b));
            
            if (notFoundYet.Count > 0 && check == amount) { 
                (int c, int d) = notFoundYet.Dequeue(); 
                group1.Add(c); group2.Add(d); 
                check = 0; amount = notFoundYet.Count;
            }                      
            check++;
        }      
        return true;
    }
}
