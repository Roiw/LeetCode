public class Solution {
    public bool IsPerfectSquare(int num) {
        if (num == 1) return true;
        int i = 1;
        while (num  > 0){
            num -= i;
            i +=2;
        }
        if (num == 0) return true;
        else return false;
    }
}
