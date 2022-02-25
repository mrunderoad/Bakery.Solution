using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CakeTests
  {
    [TestMethod]
    public void CakeMaker_CreatesInstanceOfCake_Cake()
    {
      Cake newCake = new Cake(1, 15);
      Assert.AreEqual(typeof(Cake), newCake.GetType());
    }
  }
}