using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadMaker_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1, 3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBread_ReturnsBreadCost_Int()
    {
      int breadCost = 5;
      int breadNum = 1;
      Bread newBread = new Bread(breadCost, breadNum);
      int returnedBread = newBread.BreadCost;
      Assert.AreEqual(returnedBread, breadCost);
    }

    [TestMethod]
    public void GetBread_ReturnsCostOfZeroBreads_Int()
    {
      int breadCost = 5;
      int breadNum = 0;
      Bread newBread = new Bread(breadCost, breadNum);
      int noCost = 0;
      int cost = newBread.GetBreadCost();
      Assert.AreEqual(noCost, cost);
    }

    [TestMethod]
    public void GetBread_ReturnsCostOfTwoBreads_Int()
    {
      int breadCost = 5;
      int breadNum = 2;
      Bread newBread = new Bread(breadCost, breadNum);
      int expectedCost = 10;
      int cost = newBread.GetBreadCost();
      Assert.AreEqual(expectedCost, cost);
    }

    [TestMethod]
    public void GetBread_ReturnsCostOfThreeBreads_Int()
    {
      int breadCost = 5;
      int breadNum = 3;
      Bread newBread = new Bread(breadCost, breadNum);
      int expectedCost = 10;
      int cost = newBread.GetBreadCost();
      Assert.AreEqual(expectedCost, cost);
    }

    [TestMethod]
    public void GetBread_ReturnsCostOfFourBreads_Int()
    {
      int breadCost = 5;
      int breadNum = 4;
      Bread newBread = new Bread(breadCost, breadNum);
      int expectedCost = 15;
      int cost = newBread.GetBreadCost();
      Assert.AreEqual(expectedCost, cost);
    }

    [TestMethod]
    public void GetBread_ReturnsCostOfFiveBreads_Int()
    {
      int breadCost = 5;
      int breadNum = 5;
      Bread newBread = new Bread(breadCost, breadNum);
      int expectedCost = 20;
      int cost = newBread.GetBreadCost();
      Assert.AreEqual(expectedCost, cost);
    }

  }
}