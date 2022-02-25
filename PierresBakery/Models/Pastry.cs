using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int PastryCost { get; }
    public int PastryNum { get; }
    public Pastry(int pastryCost, int pastryNum)
    {
      PastryCost = 2;
      PastryNum = pastryNum;
    }

    public int GetPastryPrice()
    {
      int PastryCost = 2;

      if (PastryNum == 1)
      {
        PastryCost = 2;
      }
      else if (PastryNum == 2)
      {
        PastryCost = 3;
      }
      else if (PastryNum == 3)
      {
        PastryCost = 5;
      }
      else if (PastryNum == 4)
      {
        PastryCost = 7;
      }
      else if (PastryNum == 5)
      {
        PastryCost = 9;
      }
      else if (PastryNum == 6)
      {
        PastryCost = 10;
      }
      else
      {
        return PastryNum * 2;
      }
      return PastryCost;
    }
  }
}

