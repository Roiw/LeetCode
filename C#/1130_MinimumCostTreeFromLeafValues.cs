public class Solution {
    // O(N) Max Stack adaptation.
    // We relax local minimums. {3,2,5} -> 2 is a local minimum.
    // We add sum += 2 * 3. Removing 2 from our stack. 
    // The idea is to keep the biggest values on the stack and add them to the sum last (so they are closer to the root of the tree)! 
    public int MctFromLeafValues(int[] arr) {
       Stack<int> stck = new Stack<int>();
        int sum  = 0;
        foreach(int i in arr){
            if (stck.Count < 2) { stck.Push(i); continue;} // We cant compare if we have less than 3 elements in the array.
            while(stck.Peek() < i && stck.Count > 1){ 
                int n = stck.Pop(), m = stck.Pop(); 
                sum += n * Math.Min(m, i); 
                if (m < n) stck.Push(n);  // Local minimum is either m or n
                else stck.Push(m);
            }
            stck.Push(i);
        }
        // Calculate the remaining elements on the stack.
        while (stck.Count > 1){
            sum += stck.Pop() * stck.Peek();
        }
        return sum;
    }
}
