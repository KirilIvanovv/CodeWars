namespace Solution
{
  public static class Program
  {
    public static double basicOp(char operation, double value1, double value2)
    {
      double result = 0;
      
      if(operation.ToString() == "+") result = value1 + value2;      
      if(operation.ToString() == "-") result = value1 - value2;      
      if(operation.ToString() == "*") result = value1 * value2;     
      if(operation.ToString() == "/") result = value1 / value2;
​
      return result;
    }
  }
}