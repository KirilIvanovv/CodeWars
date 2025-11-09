using System;
​
public class NthSeries {
  
  public static string seriesSum (int n) 
  {
    // Happy Coding ^_^
    if (n == 0)
      return "0.00";
    
    double sum = 0;
    double x = 1;
    
    for(int i = 0; i < n; i++)
    {
      sum += 1 / x;
      x += 3;
    }
    
    return sum.ToString("F2");
  }
}