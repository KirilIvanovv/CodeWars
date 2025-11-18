class Solution 
{
  public static int Stray(int[] numbers)
  {
    int a = numbers[0];
    int b = numbers[1];
    int c = numbers[2];
​
    if (a == b)
    {
      for (int i = 2; i < numbers.Length; i++)
      {
        if (numbers[i] != a)
          return numbers[i];
      }
      return a; 
    }
​
    return (a == c) ? b : a;
  }
}
​