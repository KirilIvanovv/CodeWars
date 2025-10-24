public class Fibonacci
{
  public int NthFib(int n)
  {
    if(n == 1) return 0;
    if(n == 2) return 1;
    
    int a = 0;
    int b = 1;
    int temp = 0;
    for(int i = 3; i <= n ; i++)
    {
      temp = a + b;
      a = b;
      b = temp;
    }
    return temp;
  }
}