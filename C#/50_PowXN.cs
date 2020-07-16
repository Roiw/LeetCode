public class Solution {
    public double MyPow(double x, int n) {
        if (n == 0) return 1; 
        if (n == 1) return x;
        if (n == -1) return 1/x;    
        double halfie = n % 2 == 0? MyPow(x, n/2) : MyPow(x, (n-1)/2);
        if (n % 2 == 0) return halfie * halfie;
        else return halfie * halfie * MyPow(x,1);
    }
}
