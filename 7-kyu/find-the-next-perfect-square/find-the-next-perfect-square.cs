using System;
​
public class Kata
{
  public static long FindNextSquare(long num)
  {
    if (num < 0)
      return -1;
​
    long root = (long)Math.Sqrt(num); 
​
    if (root * root != num)
      return -1;
​
    long next = root + 1;
    return next * next;
  }
}