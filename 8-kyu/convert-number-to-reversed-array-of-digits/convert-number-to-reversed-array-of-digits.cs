using System;
using System.Linq;
using System.Collections.Generic;
​
namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
      string str = n.ToString();
      char[] arr = str.ToCharArray();
      Array.Reverse(arr);
      long[] result = arr.Select(c => (long)(c - '0')).ToArray();
      
      return result;
    }
  }
}