using System.Collections.Generic;
​
public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
      List<int> reversed = new List<int>(list);
      reversed.Reverse();
      return reversed;
  }
}