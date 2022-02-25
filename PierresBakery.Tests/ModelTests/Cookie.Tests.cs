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
  }
}