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
        CookieCost = 3;
      }
      else if (CookieNum == 5)
      {
        CookieCost = 6;
      }
      else if (CookieNum == 10)
      {
        CookieCost = 15;
      }
      else
      {
        return CookieNum * 3;
      }
      return CookieCost;
    }    
  }
}