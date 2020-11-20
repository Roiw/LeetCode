public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (n == 0)
            return true;

        bool past = true;
        
        for (int i = 0; i < flowerbed.Length - 1; i++) {
            if (flowerbed[i + 1] == 0 && flowerbed[i] == 0 && past) {
                past = false;
                n--;
            }
            else if (flowerbed[i] == 0) {
                past = true;
            }
            else {
                past = false;
            }
            if (n == 0)
                return true;
        }
        
        if (flowerbed[flowerbed.Length - 1] == 0 && past && n == 1){
            return true;
        }
        
        return false;
    }
}
