class AverageSolution
{
  public static double FindAverage(double[] array)
  {
    double sum = 0;
    foreach (double x in array) 
    {
      sum += x;
    }
    return sum / array.Length;
  }
} 