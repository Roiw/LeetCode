public class Solution {
    // We want to count the permutations in lexicographical order.
    // We will get the next permutation K times and return it. But how to find the next permutation?

    // How to find the next Permutation?
    // 1  - We iterate on the array using two loops (A,B) 
    // 2  - For every A we will find the first position B, starting from the rightmost and ending on A, that is greater than A. 
    // 3a - If don't find any position after searching all A's we are at the end of the permutation set. (eg: start:[123] end:[321] )
    // 3b - If we found a position we swap A and B and all elements right of A (A+1 and so forward).
    // At the end we have the Next permutation.
    
    public string GetPermutation(int n, int k) {
        int[] arr = new int[n];
        for(int j = 0; j < n; j++) {arr[j] = j+1;}
        while (k > 1) { 
            Next(arr);
            k--;
        }
        return String.Join("", arr);
    }
    
    // The next lexicographical permutation.
    private void Next(int[] arr) {
        for (int a = arr.Length-2; a >= 0; a--){
            for (int b = arr.Length-1; b >= a; b--){
                if (arr[a] < arr[b]){
                    Swap(arr,a,b);
                    int j = arr.Length -1, i = a + 1;
                    while(i < j) {
                        Swap(arr,i,j);
                        i++; j--;
                    }
                    return;
                }
            }
        }
    }
    
    private void Swap(int[] arr, int a, int b){
        int aux = arr[a];
        arr[a] = arr[b];
        arr[b] = aux;
    }
  
}
