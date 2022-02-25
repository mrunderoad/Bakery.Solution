using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryMaker_CreatesInstanceOfPastry_Pastry()
    {
     Pastry newPastry = new Pastry(1, 4);
     Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastry_ReturnsPastryCost_Int()
    {
      int pastryCost = 2;
      int pastryNum = 1;
      Pastry newPastry = new Pastry(pastryCost, pastryNum);
      int returnedPastry = newPastry.PastryCost;
      Assert.AreEqual(returnedPastry, pastryCost);
    }

    [TestMethod]
    public void GetPastry_ReturnsCostOfOnePastry_Int()
    {
      int pastryCost = 2;
      int pastryNum = 0;
      Pastry newPastry = new Pastry(pastryCost, pastryNum);
      int noCost = 0;
      int cost = newPastry.GetPastryPrice();
      Assert.AreEqual(noCost, cost);
    }

    [TestMethod]
    public void GetPastry_ReturnsCostOfTwoPastries_Int()
    {
      int pastryCost = 2;
      int pastryNum = 2;
      Pastry newPastry = new Pastry(pastryCost, pastryNum);
      int expectedCost = 3;
      int cost = newPastry.GetPastryPrice();
      Assert.AreEqual(expectedCost, cost);
    }

    // [TestMethod]
    // public void GetPastry_ReturnsCostOfThreePastries_Int()
    // {
    //   int pastryCost = 2;
    //   int pastryNum = 3;
    //   Pastry newPastry = new Pastry(pastryCost, pastryNum);
    //   int expectedCost = 5;
    //   int cost = newPastry.GetPastryPrice();
    //   Assert.AreEqual(expectedCost, cost);
    // }

    // [TestMethod]
    // public void GetPastry_ReturnsCostOfFourPastries_Int()
    // {
    //   int pastryCost = 2;
    //   int pastryNum = 4;
    //   Pastry newPastry = new Pastry(pastryCost, pastryNum);
    //   int expectedCost = 7;
    //   int cost = newPastry.GetPastryPrice();
    //   Assert.AreEqual(expectedCost, cost);
    // }

    // [TestMethod]
    // public void GetPastry_ReturnsCostOfFivePastries_Int()
    // {
    //   int pastryCost = 2;
    //   int pastryNum = 5;
    //   Pastry newPastry = new Pastry(pastryCost, pastryNum);
    //   int expectedCost = 9;
    //   int cost = newPastry.GetPastryPrice();
    //   Assert.AreEqual(expectedCost, cost); 
    // }

    // [TestMethod]
    // public void GetPastry_ReturnsCostOfSixPastries_Int()
    // {
    //   int pastryCost = 2;
    //   int pastryNum = 6;
    //   Pastry newPastry = new Pastry(pastryCost, pastryNum);
    //   int expectedCost = 10;
    //   int cost = newPastry.GetPastryPrice();
    //   Assert.AreEqual(expectedCost, cost);
    // }
  }
}