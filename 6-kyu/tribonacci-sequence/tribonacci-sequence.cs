using System;
public class Xbonacci
{
  public double[] Tribonacci(double[] signature, int n)
  {
    if(n == 0) return new double[0];
   
    double[] result = new double[n];
    
    for (int i = 0; i < Math.Min(3, n); i++)
    {
      result[i] = signature[i];
    }
    
    for(int i = 3; i < n; i++)
    {
      result[i] = result[i - 1] + result[i - 2] + result[i - 3];
    }
    
    return result;
    
  }
}