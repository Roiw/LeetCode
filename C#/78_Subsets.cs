public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        // Initialize the answer.
        List<IList<int>> ans = new List<IList<int>>();
        
        // Add first element 'empty'
        ans.Add(new List<int>());
        
        // Foreach int in nums
        foreach(int n in nums) {
            // Foreach answer in ans.
            int count = ans.Count;
            for (int i = 0; i < count; i++){
                List<int> toAdd = new List<int>(ans[i]);
                toAdd.Add(n);
                ans.Add(toAdd);
            }
        }
        return ans;
    }  
}
/*
        Assembles the answer in this order..
        []
        1
        2
        12
        3
        13
        23
        123
        4
        14
        24
        124
        34
        134
        234
        1234

*/