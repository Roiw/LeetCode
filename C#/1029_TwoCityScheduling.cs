public class Solution {
    // 55
    // A: 
    // B:
    // Take minor (between A and B) if added already pick again. -> Add element to 
    public int TwoCitySchedCost(int[][] costs) {
        
        HashSet<int> inserted = new HashSet<int>();
        SortedDictionary<int, Stack<int>> sortedForA = new SortedDictionary<int,Stack<int>>();
        SortedDictionary<int, Stack<int>> sortedForB = new SortedDictionary<int,Stack<int>>();
        int ans = 0;
        
        // O(NLogN)
        for (int i = 0; i < costs.Length; i++){
            sortedForA.TryAdd(costs[i][0], new Stack<int>());
            sortedForA[costs[i][0]].Push(i);
            sortedForB.TryAdd(costs[i][1], new Stack<int>());
            sortedForB[costs[i][1]].Push(i);
        }
        
        var As = sortedForA.Keys.GetEnumerator();
        var Bs = sortedForB.Keys.GetEnumerator();
        bool isAValid = As.MoveNext();
        bool isBValid = Bs.MoveNext();
        int amountA = 0, amountB = 0;
        
        while (inserted.Count < costs.Length){
            
            if ( !isBValid ||amountB >= costs.Length/2 ||
                isAValid && amountA < costs.Length/2 && As.Current < Bs.Current){
                (int s, int items) = AddElements(inserted, sortedForA, As.Current); 
                ans += s; amountA += items;
                isAValid = As.MoveNext();
            }
            if (!isAValid || amountA >= costs.Length/2 || 
                isBValid && amountB < costs.Length/2 && As.Current >= Bs.Current) {
                (int s, int items) = AddElements(inserted, sortedForB, Bs.Current);
                ans += s; amountB += items;
                isBValid = Bs.MoveNext();
            }
            else break;
        }  
        return ans;
    }
    private (int, int) AddElements(HashSet<int> inserted, SortedDictionary<int, Stack<int>> sorted, int index ){
        int summed = 0, count = 0;
        while (sorted[index].Count > 0){
           int val = sorted[index].Pop();
           if (inserted.Add(val)) {
               summed += index;
               count++;
            }
        }
        return (summed, count);
    }
}
