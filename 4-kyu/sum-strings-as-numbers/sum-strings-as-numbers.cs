using System;
using System.Numerics;
​
public static class Kata
{
    public static string sumStrings(string a, string b)
    {
      if (string.IsNullOrWhiteSpace(a)) a = "0";
      if (string.IsNullOrWhiteSpace(b)) b = "0";
​
      a = a.TrimStart('0');
      b = b.TrimStart('0');
​
      if (a == "") a = "0";
      if (b == "") b = "0";
​
      BigInteger num1 = BigInteger.Parse(a);
      BigInteger num2 = BigInteger.Parse(b);
​
      BigInteger sum = num1 + num2;
​
      return sum.ToString();
    }
}