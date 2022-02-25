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
  }
}