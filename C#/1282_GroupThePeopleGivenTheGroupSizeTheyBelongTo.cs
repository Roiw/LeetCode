public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        
        IList<IList<int>> rtn  = new List<IList<int>>();
        
        Dictionary<int, List<List<int>>> dic = new Dictionary<int, List<List<int>>>();
        for (int n = 0; n < groupSizes.Length; n++) {
            if(dic.ContainsKey(groupSizes[n])) {
                int len = dic[groupSizes[n]].Count;
                if (dic[groupSizes[n]][len - 1].Count < groupSizes[n])
                    dic[groupSizes[n]][len - 1].Add(n);
                else
                    dic[groupSizes[n]].Add(new List<int>(){n});      
            }
            else
                dic.Add(groupSizes[n], new List<List<int>>(){new List<int>(){n}});
        }
        
        foreach (List<List<int>> v in dic.Values){
            foreach (List<int> l in v)
                rtn.Add(l);
        }
       return rtn;
    }
}
