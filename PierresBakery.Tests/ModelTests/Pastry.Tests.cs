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
  }
}