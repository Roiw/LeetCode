public class Solution {

    public int[][] ReconstructQueue(int[][] people) {

        SortedDictionary<int, List<int>> elems = new SortedDictionary<int, List<int>>();      
        for (int i = 0; i < people.Length; i++){
            elems.TryAdd(people[i][0], new List<int>());
            elems[people[i][0]].Add(people[i][1]);
        }
        
        List<int> keys = elems.Keys.ToList();
        LinkedList<int[]> ans = new LinkedList<int[]>();

        for (int i = keys.Count-1; i >= 0; i--){ // Foreach person..
            int h = keys[i];
            elems[h].Sort();
            foreach (int inFront in elems[h]) {  // Add on the right place..
                LinkedListNode<int[]> node = ans.First;
                int count = 0;
                while (node != null && count < inFront ) {
                    node = node.Next;
                    count++;
                }
                if (node == null)
                    ans.AddLast(new int[]{h,inFront});
                else
                    ans.AddBefore(node, new int[]{h,inFront});
            }
        }
        // Assembling answer..
        return ans.ToArray();
    }
}
