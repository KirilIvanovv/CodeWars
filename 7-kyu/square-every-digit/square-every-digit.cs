using System;
using System.Collections;
using System.Collections.Generic;
​
public class Kata
{
  public static int SquareDigits(int n)
  {
    string nums = n.ToString();
    string result = "";
​
    foreach (char c in nums)
    {
        int digit = c - '0';
        result += (digit * digit).ToString();
    }
​
    return int.Parse(result);
    }
}