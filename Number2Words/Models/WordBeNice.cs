using System;
using System.Collections.Generic;

namespace Number2Words.Models
{
  public class WordBeNice
  {
    public int NumberConv { get; set; }
    
    public Dictionary<int, string> numToWord = new Dictionary<int, string>() { {1, "one"}, {2, "two"}, {3, "three"}, {4, "four"}, {5, "five"}, {6, "six"}, {7, "seven"}, {8, "eight"}, {9, "nine"}};

    public WordBeNice(int numberInput)
    {
      NumberConv = numberInput;
    }
    
    public string NumConvert()
    {
      return "fsbkjahfksef";
    }
  }
}