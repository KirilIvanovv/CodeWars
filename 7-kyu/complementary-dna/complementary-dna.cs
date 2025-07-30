public class DnaStrand 
  {
      public static string MakeComplement(string dna)
      {
        string result = "";
​
        foreach(char  c in dna)
        {
            if(c == 'C')
            {
                result += 'G';
            }
            else if(c == 'G')
            {
                result += 'C';
            }
            else if (c == 'A')
            {
                result += 'T';
            }
            else if (c == 'T')
            {
                result += 'A';
            }
        }
        
        return result;
      }
  }