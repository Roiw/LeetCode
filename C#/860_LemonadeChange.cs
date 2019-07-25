public class Solution 
{
    public bool LemonadeChange(int[] bills) 
    {
        // maximize the amount of 5's that I have.
        int[] amountOfBills = new int[2]; // 0 has the amount of 5's, 1 the amount of 10's and 2 the 20's
        
        for (int i= 0; i < bills.Length; i++)
        {
            if (bills[i] == 5)
            {
                amountOfBills[0] ++; // Recieving money..
                
            }           
            else if (bills[i] == 10)
            {
                if(amountOfBills[0] >= 1)
                {
                    amountOfBills[1] ++; // Recieving money..
                    amountOfBills[0] --; // Giving a 5 as change..
                    
                }               
                else
                    return false;
            }
            else if (bills[i] == 20)
            {
                if(amountOfBills[1] >= 1 && amountOfBills[0] >= 1)
                {
                    amountOfBills[1]--; // Giving a 10 as change..
                    amountOfBills[0]--; // Giving a 5 as change..
                    
                }
                else if (amountOfBills[0] >= 3)
                {
                    amountOfBills[0] = amountOfBills[0] -3; // Giving 3 5's as change..
                    
                }
                else
                    return false;                    
            }
        }
        
        // give as change the biggest bill I can.
        // 20 -> (10 and a 5) or (5 5 5)
        // 10 -> 5
        
        // Keep notice of the amount of each bill that I have
        
        // what about the case where? 5,10,5,5,20  guess that's false.
        
        return true;
    }
}
