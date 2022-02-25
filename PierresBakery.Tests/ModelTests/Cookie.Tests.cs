using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class CookieTests
  {
    [TestMethod]
    public void CookieMaker_CreatesInstanceOfCookie_Cookie()
    {
      Cookie newCookie = new Cookie(1, 3);
      Assert.AreEqual(typeof(Cookie), newCookie.GetType());
    }

    [TestMethod]
    public void GetCookie_ReturnsCookiePrice_Int()
    {
      int cookieCost = 3;
      int cookieNum = 1;
      Cookie newCookie = new Cookie(cookieCost, cookieNum);
      int returnedCookie = newCookie.CookieCost;
      Assert.AreEqual(returnedCookie, cookieCost);
    }
  }
}