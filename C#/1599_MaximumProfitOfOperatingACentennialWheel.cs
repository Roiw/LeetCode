/*
    Calculate running cost, save it on array. Return max.
*/

public class Solution {
    public int MinOperationsMaxProfit(int[] customers, int boardingCost, int runningCost) {
        int accumulated = customers[0];
        int profit = 0, maxProfit = Int32.MinValue, index = -1, i = 0;  
        while ( accumulated > 0 || i < customers.Length ) {      
            int toBoard = accumulated >= 4? 4: accumulated;
            accumulated -= toBoard;
            
            profit+= toBoard * boardingCost - runningCost;
            if (profit > maxProfit && profit > 0){
                maxProfit = profit;
                index = i + 1;
            }
            
            i++;
            
            accumulated += i < customers.Length? customers[i] : 0; 
        }
        
        return index;      
    }
}
