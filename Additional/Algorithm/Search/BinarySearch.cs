namespace Algorithm.Search 
{
    public static class BinarySearch
    {
         public static int Search(int target, int[] arr, int start, int finish) 
        {
            if (start > finish) 
                return ~finish;
            
            int mid = start + (finish - start) / 2;
            
            if (arr[mid] == target) 
                return mid;
            
            if (arr[mid] < target) 
                return Search(target, arr, mid + 1, finish);
            
            else 
                return Search(target, arr, start, mid - 1); 
        }
    }
}