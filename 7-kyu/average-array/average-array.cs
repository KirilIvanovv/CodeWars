public class Kata
{
  public static double[] AvgArray(double[][] arr)
  {
    int rows = arr.Length;
    int cols = arr[0].Length;
    
    double[] result = new double[cols];
    double sum = 0;
    
    for(int i = 0; i < cols; i++)
    {
      for(int j = 0; j < rows; j++)
      {
        sum += arr[j][i]; 
      }
      sum = sum / rows;
      result[i] += sum;
      sum = 0;
    }
    
    return result;
  }
}