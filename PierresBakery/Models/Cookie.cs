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
      return 9;
    }    
  }
}