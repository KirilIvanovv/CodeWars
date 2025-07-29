using System;
using System.Collections.Generic;
​
public class FizzBuzz
{
  public static string[] GetFizzBuzzArray(int n)
  {
    string[] arr = new string[n];
    
    for (int i = 1; i <= n; i++)
    {
        if (i % 15 == 0)
        {
            arr[i -1] += "FizzBuzz";
        }
        else if (i % 5 == 0)
        {
            arr[i - 1] += "Buzz";
        }
        else if (i % 3 == 0)
        {
            arr[i - 1] += "Fizz";
        }
        else
        {
            arr[i - 1] += i.ToString();
        }
    }
    
    return arr;
  }
}