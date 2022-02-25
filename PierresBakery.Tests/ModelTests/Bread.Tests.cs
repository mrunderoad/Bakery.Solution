using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

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

    // [TestMethod]
    // public void 
    // {

    // }
  }
}