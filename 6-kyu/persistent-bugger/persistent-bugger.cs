using System;
using System.Collections.Generic;
using System.Linq;
​
public class Persist 
{
  public static int Persistence(long n) 
  {
    long nn = 1;
    int count = 0;
​
    while(n > 9)
    {
        if(n < 10)
        {
            return count;
        }
        else
        {
            string num = n.ToString();
​
            List<int> ints = num.Select(i => i - '0').ToList();
​
            foreach (int b in ints)
            {
                nn *= b;
            }
​
            n = nn;
            count++;
            nn = 1;
        }
​
    }
​
    return count;   
  }
}