public class Solution {
    public int FindEvenPivot(int[] A, int lastPivot, int currentIndex){
        int pivot = lastPivot;
        while (pivot > currentIndex){
            if (A[pivot] % 2 == 0)
                return pivot;
            else
                pivot--;
        }
        return pivot;
    }
    public int[] SortArrayByParity(int[] A) {
        int index = 0;
        int pivot = FindEvenPivot(A, A.Length -1, index);
        if (pivot == -1)
            return A; // No even number;     
        while (index <= pivot){
            if (A[index] % 2 != 0){
                int aux = A[index];
                A[index] = A[pivot];
                A[pivot] = aux;
                pivot = FindEvenPivot(A, pivot, index);
            }
            index++;
        }
        return A;
    }
}
