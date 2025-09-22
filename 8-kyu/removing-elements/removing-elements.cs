  public static class Kata
  {
      public static object[] RemoveEveryOther(object[] arr)
      {
        object[] result = new object[(arr.Length + 1) / 2];
        int index = 0;
        for (int i = 0; i < arr.Length; i += 2)
        {
            result[index] = arr[i];
            index++;
        }
        return result;
      }
  }