using System;
using System.Collections.Generic;

namespace Number2Words.Models
{
  public class WordBeNice
  {
    public int NumberConv { get; set; }
    
    public Dictionary<int, string> numToWord = new Dictionary<int, string>() { {1, "one"}, {2, "two"}, {3, "three"}, };

    public WordBeNice(int numberConv;
    {
      NumberConv = numberConv
    }
    
    public static string NumConvert()
    {
      return "fsbkjahfksef";
    }
  }
}