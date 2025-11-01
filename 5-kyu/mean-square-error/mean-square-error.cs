public class Kata
{
  public static double Solution(int[] firstArray, int[] secondArray)
  {
    double sum = 0;
    int len = firstArray.Length;
    
    for(int i = 0; i < len; i++)
    {
      int dif = firstArray[i] - secondArray[i];
      sum += dif * dif;
    }
    
    return sum / len;
  }
}