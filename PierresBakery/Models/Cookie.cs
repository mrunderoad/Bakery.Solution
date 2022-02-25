using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Cookie
  {
    public int CookieCost { get; }
    public int CookieNum { get; }
    public Cookie(int cookieCost, int cookieNum)
    {
      CookieCost = 3;
      CookieNum = cookieNum;
    }

    public int GetCookieCost()
    {
      int CookieCost = 3;

      if (CookieNum == 1)
      {
        return CookieCost = 3;
      }
      else if (CookieNum == 5)
      {
        return CookieCost = 6;
      }
      else if (CookieNum == 10)
      {
        return CookieCost = 15;
      }
      else
      {
        return CookieNum * 3;
      }
    }    
  }
}