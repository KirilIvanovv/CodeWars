using System;
using System.Collections.Generic;
​
public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        int currentPassengers = 0;
        
        foreach (int[] stop in peopleListInOut)
        {
            currentPassengers += stop[0] - stop[1];
        }
        
        return currentPassengers;
    }
}