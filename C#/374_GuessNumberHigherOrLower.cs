/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int BinSearch( int lower, int higher) {
        int mid = lower + (higher-lower)/2;
        
        int g = guess(mid);
        if (g == 0)
            return mid;
        if (g == 1)
            return BinSearch(mid + 1, higher);
        else
            return BinSearch(lower, mid - 1);
        
    }
    public int GuessNumber(int n) {
        return BinSearch(1, n);
    }
}
