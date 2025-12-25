using System;
​
public class LoveDetector
{
    public static bool lovefunc(int flower1, int flower2)
    { 
      int sum = (flower1 + flower2);
      if(sum % 2 != 0) return true;
      else return false;
      
    }
}