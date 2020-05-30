public class Solution {
    public int[][] KClosest(int[][] points, int K) {
        SortedDictionary<double,List<int[]>> closest = new SortedDictionary<double, List<int[]>>();
        // Sort based on distance..
        for (int i = 0; i < points.Length; i++){
            double distance = CalculateDistance(points[i]);
            closest.TryAdd(distance, new List<int[]>());
            closest[distance].Add(points[i]);
        }
        
        // Assemble answer
        int[][] rtn = new int[K][];
        var elements = closest.Values.GetEnumerator();
        elements.MoveNext();
        for (int i = 0; i < rtn.Length; i++){
            for (int j = 0; j < elements.Current.Count; j++){
                rtn[i + j] = elements.Current[j];
            }
            i = i + elements.Current.Count - 1;
            elements.MoveNext();
        }
        return rtn;
    }
    
    private double CalculateDistance(int[] point){
        double p1 = Math.Pow((double)point[0], 2);
        double p2 = Math.Pow((double)point[1], 2);
        return Math.Sqrt(p1 + p2);  
    }
}
