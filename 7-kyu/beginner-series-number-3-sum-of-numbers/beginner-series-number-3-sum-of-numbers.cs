 using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
        if (a > b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
​
        int result = 0;
        for (int i = a; i <= b; i++)
        {
            result += i;
        }
        return result;
     }
  }