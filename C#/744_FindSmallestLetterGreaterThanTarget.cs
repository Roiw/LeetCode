public class Solution {
    private int BinarySearch(char[] arr, int min, int max, char target) {
        if (min > max)
            return ~min; // Returns to me the position the element should be.
        int mid = min + (max - min) /2;
        if (arr[mid] <= target)
            return BinarySearch(arr, mid + 1, max, target); // Go right 
        else
            return BinarySearch(arr, min, mid - 1, target); // Go left
    }
    public char NextGreatestLetter(char[] letters, char target) {
        int ans = BinarySearch(letters, 0, letters.Length - 1, target);
        if (ans < 0) {
            ans = ~ans;
            if (ans <= letters.Length -1)
                return letters[ans];
            return letters[0];
        }
        if (ans == letters.Length)
            return letters[0];
        return letters[ans];
    }
}
