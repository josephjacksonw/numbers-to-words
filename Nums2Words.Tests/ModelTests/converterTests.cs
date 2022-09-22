// testing

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Converter.Models;

namespace Converter.Models.Tests
{
  [TestClass]
  public class TranslatorTest
  {
    [TestMethod]
    public void changer_makeAWordOfNum_True()
    {
      Translator bariable = new Translator();
      Assert.AreEqual("nineteen", bariable.changer(19));
    }
  }
}
