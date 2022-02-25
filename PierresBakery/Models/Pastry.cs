using System.Collections.Generic;
using System;

namespace PierresBakery
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
        return PastryCost = 2;
      }
      else if (PastryNum == 2)
      {
        return PastryCost = 3;
      }
      else if (PastryNum == 3)
      {
        return PastryCost = 5;
      }
      else if (PastryNum == 4)
      {
        return PastryCost = 7;
      }
      else if (PastryNum == 5)
      {
        return PastryCost = 9;
      }
      else if (PastryNum == 6)
      {
        return PastryCost = 10;
      }
      else
      {
        return PastryNum * 2;
      }
    }
  }
}

//One pastry = 2
//Two pastry = 3
//three pastry = 5
//four pastry = 7
//five pastry = 9
//six pastry = 10

