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

    [TestMethod]
    public void GetCake_ReturnsCakeCost_Int()
    {
      int cakeCost = 15;
      int cakeNum = 1;
      Cake newCake = new Cake(cakeCost, cakeNum);
      int returnedCake = newCake.CakeCost;
      Assert.AreEqual(returnedCake, cakeCost);
    }

    [TestMethod]
    public void GetCake_ReturnsCostOfOneCake_Int()
    {
      int cakeCost = 15;
      int cakeNum = 1;
      Cake newCake = new Cake(cakeCost, cakeNum);
      int expectedCost = 15;
      int cost = newCake.GetCakeCost();
      Assert.AreEqual(expectedCost, cost);
    }

    [TestMethod]
    public void GetCake_ReturnsCostOfThreeCakes_INt()
    {
      int cakeCost = 15;
      int cakeNum = 3;
      Cake newCake = new Cake(cakeCost, cakeNum);
      int expectedCost = 30;
      int cost = newCake.GetCakeCost();
      Assert.AreEqual(expectedCost, cost);
    }
  }
}