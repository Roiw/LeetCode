namespace Algorithm.Sorting 
{
    // O(n²)
    public static class BubbleSort 
    {
        public static int[] Sort(int[] unsorted) 
        {
            bool hasChanged = true;
            while( hasChanged) 
            {
                hasChanged = false;
                for (int i = 0; i < unsorted.Length -1 ; i++)
                {
                    if (unsorted[i] > unsorted[i+1]) 
                    {
                        int aux = unsorted[i+1];
                        unsorted[i+1] = unsorted[i];
                        unsorted[i] = aux;
                        hasChanged = true;
                    }
                }                 
            }
            return unsorted;            
        }
    }
}
