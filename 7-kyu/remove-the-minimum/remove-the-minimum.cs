using System;
using System.Collections.Generic;
using System.Linq;
​
public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    if (numbers == null || numbers.Count == 0)
      return numbers;
    
    int a = 0;
    
    for(int i = 1; i < numbers.Count; i++)
    {
      if(numbers[i] <  numbers[a])
      {
        a = i;
      }
    }
    
    numbers.RemoveAt(a);
    
    return numbers;
  }
}