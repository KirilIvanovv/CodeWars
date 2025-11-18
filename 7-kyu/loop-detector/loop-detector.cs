using System.Collections.Generic;
​
namespace Solution
{
  public class Kata
  {
    public static bool HasLoop(int[] arr)
    {
      if(arr == null || arr.Length == 0)
      {
        return false;
      }
      
      List<int> x = new List<int>();
      int a = 0;
      
      while(true)
      {
        if(a < 0 || a >= arr.Length) {return false;}
        
        if (x.Contains(a)) {return true;}
        
        x.Add(a);
        a = arr[a];
      }
      
    }
  }
}