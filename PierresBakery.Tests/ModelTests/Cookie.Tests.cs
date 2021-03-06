using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

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

    [TestMethod]
    public void GetCookie_ReturnsCostOfOneCookie_Int()
    {
      int cookieCost = 3;
      int cookieNum = 1;
      Cookie newCookie = new Cookie(cookieCost, cookieNum);
      int expectedCost = 3;
      int cost = newCookie.GetCookieCost();
      Assert.AreEqual(expectedCost, cost);
    }

    [TestMethod]
    public void GetCookie_ReturnsCostOfFiveCookies_Int()
    {
      int cookieCost = 3;
      int cookieNum = 5;
      Cookie newCookie = new Cookie(cookieCost, cookieNum);
      int expectedCost = 6;
      int cost = newCookie.GetCookieCost();
      Assert.AreEqual(expectedCost, cost);
    }

    [TestMethod]
    public void GetCookie_ReturnsCostOfTenCookies_Int()
    {
      int cookieCost = 3;
      int cookieNum = 10;
      Cookie newCookie = new Cookie(cookieCost, cookieNum);
      int expectedCost = 15;
      int cost = newCookie.GetCookieCost();
      Assert.AreEqual(expectedCost, cost);
    }
  }
}