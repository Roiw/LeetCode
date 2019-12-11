using System;
namespace Algorithm.Sorting 
{
    // O(nLog(n))
    public static class MergeSort 
    {
        public static int[] Sort(int[] unsorted) 
        {
            // Base case..         
            if (unsorted.Length == 1)
                return unsorted;
            
            int rightLength = (unsorted.Length % 2 == 0) ? unsorted.Length/2 : unsorted.Length/2 + 1;

            // Break array into halves..
            int[] left = new int[unsorted.Length/2];
            int[] right = new int[rightLength]; 
            Array.Copy(unsorted, 0, left, 0, unsorted.Length/2);
            Array.Copy(unsorted, unsorted.Length/2, right, 0, rightLength);

            // Sort each half..
            left = Sort(left);
            right = Sort(right);

            // Merge the halves..
            return Merge(left, right);     
        }

        public static int[] Merge(int[] left, int[] right) 
        {
            int[] ans = new int[left.Length + right.Length];
            int l = 0;
            int r = 0;

            for (int i = 0; i < left.Length + right.Length; i++)
            {
                if (left.Length <= l )
                {
                    ans[i] = right[r];
                    r++;
                }
                else if (right.Length <= r)
                {
                    ans[i] = left[l];
                    l++;
                }
                else if (left[l] > right[r])
                {
                    ans[i] = right[r];
                    r++;
                }
                else
                {
                    ans[i] = left[l];     
                    l++;
                }
            }
            return ans;
        }
    }
}
