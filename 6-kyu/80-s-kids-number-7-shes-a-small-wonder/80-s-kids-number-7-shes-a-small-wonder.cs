​
  public string LearnWord(string word)
  {
    string reply;
    string storage = word.ToLower();
    if (!word.All(Char.IsLetter) | word == "")
    {
        reply = "I do not understand the input";
    }
    else 
    {
      try
      {
          vickiesDictionary.Add(storage, word);
          reply = $"Thank you for teaching me {word}";
      }
      catch
      {
          reply = $"I already know the word {word}";
      }
    }
    return reply;
  }
}