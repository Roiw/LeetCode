public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        List<int> ans = new List<int>();
        Dictionary<int,HashSet<int>> reqs = new Dictionary<int,HashSet<int>>();
        // Initialize lists..
        for(int i = 0; i < numCourses; i++) reqs.Add(i, new HashSet<int>());
        // Populating
        for (int i = 0; i < prerequisites.Length; i++) {
            int a = prerequisites[i][0], b = prerequisites[i][1];
            reqs[a].Add(b);
        }
        while (reqs.Count > 0) {
            var canTake = reqs.Where(k => k.Value.Count == 0).ToList();
            foreach (var c in canTake) {
                ans.Add(c.Key);
                reqs.Remove(c.Key);
                reqs = new Dictionary<int, HashSet<int>>(reqs.Select((k) => {
                        k.Value.Remove(c.Key);
                        return k;
                    }));
            }
            if (canTake.Count == 0) return new int[]{};          
        }
        return ans.ToArray();
    }
}
