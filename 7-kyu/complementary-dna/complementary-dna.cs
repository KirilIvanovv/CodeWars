public class DnaStrand 
{
  public static string MakeComplement(string dna)
  {            
      return dna.Replace("A","t")
                .Replace("T","a")
                .Replace("G","c")
                .Replace("C","g")
                .ToUpper();
    }
}