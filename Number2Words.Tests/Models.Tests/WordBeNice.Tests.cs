using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Number2Words.Models;
using System;

namespace Number2Words.Models.Tests
{
  [TestClass]
  public class ModelsTest
  {
    [TestMethod]
    public void NumConvert_ConvertsSingleDigit_True()
    {
      WordBeNice word = new WordBeNice(8);
      Assert.AreEqual("eight", word.NumConvert());
    }
  }
}