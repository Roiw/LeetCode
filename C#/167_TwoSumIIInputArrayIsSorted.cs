public class Solution {
    // 04
    private int BinarySearch(int[] arr, int min, int max, int target, HashSet<int> selected){
        if (min > max)
            return ~min;
        int mid = min + (max - min)/2;
        if (arr[mid] == target) {
            if (selected.Add(mid))
                return mid;
            else {
                int r = BinarySearch(arr, mid + 1, max, target, selected);
                if (r >= 0) return r;
                return BinarySearch(arr, min, mid - 1, target, selected);
            }
        }
        if (arr[mid] < target)
            return BinarySearch(arr, mid + 1, max, target, selected);
        else
            return BinarySearch(arr, min, mid - 1, target, selected);
    }
    public int[] TwoSum(int[] numbers, int target) {
        HashSet<int> selected = new HashSet<int>();
        for (int i = 0; i < numbers.Length; i++){
            selected.Clear();
            selected.Add(i);
            int s = target - numbers[i];
            if (s >= numbers[0] && s <= numbers[numbers.Length-1]){
                int j = BinarySearch(numbers, 0, numbers.Length-1, s, selected);
                if (j >= 0){
                    if (i < j)
                        return new int[2]{i+1,j+1};
                    else
                        return new int[2]{j+1,i+1};
                }                    
            }
        }
        return new int[2];
    }
}
