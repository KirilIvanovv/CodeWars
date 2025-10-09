using System;
using System.Linq;
using System.Text.RegularExpressions;
​
public class Kata
{
  public static string FormatTime(int hour)
  {
    string result = "";
    
    string str = hour.ToString();
    char[] arr = str.ToCharArray();
    
    if (hour < 100 || hour > 9999)
    {
      throw new ArgumentException();
    }
    
    if(hour >= 1000 )
    {
      result = $"{arr[0]}{arr[1]}:{arr[2]}{arr[3]}";
    }
    else if(hour >= 100)
    {
       result = $"{arr[0]}:{arr[1]}{arr[2]}";
    }
    
    return result;
  }
}