using System;
using System.Collections.Generic;
​
public class Kata
{
    public static int Find(int[] integers)
    {
      List<int> odd = new List<int>();
      List<int> even = new List<int>();
​
      int n = 0;
​
      foreach (int i in integers)
      {
          if (i % 2 == 0) even.Add(i);
          else { odd.Add(i); }
      }
​
      if(odd.Count == 1)
      {
          n = odd[0];
      }
      else if(even.Count == 1) 
      {
          n = even[0];
      }
      
      return n;
    }
}