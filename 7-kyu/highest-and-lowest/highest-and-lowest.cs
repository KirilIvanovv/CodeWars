using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
​
public static class Kata
{
  public static string HighAndLow(string numbers)
    {
    List<int> nums = new List<int>();
​
    string[] parts = numbers.Split(' ');
​
    foreach (string p in parts)
    {
        nums.Add(int.Parse(p));
    }
​
    int max = nums.Max();
    int min = nums.Min();
​
    return max.ToString() + " " + min.ToString();
  }
}