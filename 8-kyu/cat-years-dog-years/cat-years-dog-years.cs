public class Dinglemouse {
​
  public static int[] humanYearsCatYearsDogYears(int humanYears) 
  {
    int cat = 15;
    int dog = 15;
​
    int[] result = { 0, 0, 0 };
​
    if (humanYears >= 3)
    {
      cat += 9;
      dog += 9;
      int a = humanYears - 2;
      for (int i = 0; i < a; i++)
      {
        cat += 4;
        dog += 5;
      }
    }
    else if(humanYears == 2)
    {
      cat += 9;
      dog += 9;
    }
    else { }
​
    result[0] = humanYears;
    result[1] = cat;
    result[2] = dog;
    
    return result;
  }
​
}