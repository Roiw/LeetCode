public class Solution {
    public int LongestConsecutive(int[] nums) {
        int totalLength = 0;
        if (nums.Length == 0) return 0;
        HashSet<int> used = new HashSet<int>();
        Dictionary<int,(int,int)> dic = new Dictionary<int,(int,int)>();
        
        // Foreach element on the array O(N)
        for (int i = 0; i < nums.Length; i++) {
            
            // Check if we already tested this element..
            if (used.Add(nums[i])) {
                // Define possible connections of element (Forward and Backwards)
                int a = nums[i] + 1, b = nums[i] - 1; // a = Forward, b = Backwards
                bool hasA = dic.ContainsKey(a), hasB = dic.ContainsKey(b);
            
                if (hasA && hasB) {
                    // Element has 2 connections..
                    
                    // Check forward advanced connection (C)
                    bool hasC = dic[a].Item2 != a ? true : false ;
                    int c = hasC ? dic[a].Item2: a;
                                
                    // Check backwards advanced connection (D)
                    bool hasD = dic[b].Item1 != b ? true : false ;
                    int d = hasD ? dic[b].Item1: b;    
                    
                    // Connect everything based on the data found..
                    (int,int) aV = dic[a]; (int,int) bV = dic[b];
                    (int,int) cV = dic[c]; (int,int) dV = dic[d];
                    
                    if (hasC && hasD) { 
                        cV.Item1 = d; dV.Item2 = c; 
                        dic[c] = cV; dic[d] = dV;
                        int t = Math.Abs(c - d);
                        totalLength = t > totalLength ? t : totalLength; // Check if we added a new length
                    }
                    else if (!hasC) { 
                        aV.Item1 = d; dV.Item2 = a;
                        dic[a] = aV; dic[d] = dV;
                        int t = Math.Abs(a - d);
                        totalLength = t > totalLength ? t : totalLength; // Check if we added a new length
                    }
                    else if (!hasD) { 
                        cV.Item1 = b; bV.Item2 = c;
                        dic[c] = cV; dic[b] = bV;
                        int t = Math.Abs(c - b);
                        totalLength = t > totalLength ? t : totalLength; // Check if we added a new length
                    }
                    else {
                        aV.Item1 = b; bV.Item2 = a;
                        dic[a] = aV; dic[b] = dV;
                        int t = Math.Abs(a - b);
                        totalLength = t > totalLength ? t : totalLength; // Check if we added a new length
                    }
                    
                    if (hasC) { dic.Remove(a); } // We no longer need this node..
                    if (hasD) { dic.Remove(b); } // We no longer need this node..
                    
                } else {
                    if (hasA) {
                        // Element has 1 connection..
                        (int,int) aV = dic[a];
                        int t = 0;
                        bool delA = aV.Item2 != a ? true : false;
                        if (delA){
                            (int,int) aaV = dic[aV.Item2];
                            aaV.Item1 = nums[i];
                            dic[aV.Item2] = aaV; // Updating element;
                            dic.Add(nums[i], (nums[i], aV.Item2)); // Add new connection..
                            dic.Remove(a);
                            t = Math.Abs(aV.Item2 - nums[i]); // This element total
                        } else {
                            aV.Item1 = nums[i]; // Update connection..
                            dic[a] = aV;
                            dic.Add(nums[i], (nums[i], a)); // Add new connection..
                            t = Math.Abs(a - nums[i]); // This element total
                        }   
                        totalLength = t > totalLength ? t : totalLength; // Check if we added a new length
                    }
                    else if (hasB) {                 
                        // Element has 1 connection..
                        (int,int) bV = dic[b];
                        int t = 0;
                        bool delB = bV.Item1 != b ? true : false;
                        if (delB){
                            (int,int) bbV = dic[bV.Item1];
                            bbV.Item2 = nums[i];
                            dic[bV.Item1] = bbV; // Updating element;
                            dic.Add(nums[i], (bV.Item1, nums[i])); // Add new connection..
                            dic.Remove(b);
                            t =  Math.Abs(nums[i] - bV.Item1); // This element total
                        } else {
                            bV.Item2 = nums[i]; // Update connection..
                            dic[b] = bV;
                            dic.Add(nums[i], (b, nums[i])); // Add new connection..
                            t =  Math.Abs(nums[i] - b); // This element total
                        }
                        totalLength = t > totalLength ? t : totalLength; // Check if we added a new length                
                    }
                    else {
                        // Element has no connections
                        dic.Add(nums[i], (nums[i], nums[i]));
                    }
                }
            }  
        }
        return totalLength + 1;
    }
}
