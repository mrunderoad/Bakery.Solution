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
      int pastryCost = 2;

      if (PastryNum == 1)
      {
        return pastryCost = 2;
      }
      else if (PastryNum == 2)
      {
        return pastryCost = 3;
      }
      else if (PastryNum == 3)
      {
        return pastryCost = 5;
      }
      else if (PastryNum == 4)
      {
        return pastryCost = 7;
      }
      // else if (PastryNum == 5)
      // {
      //   return pastryCost = 9;
      // }
      // else if (PastryNum == 6)
      // {
      //   return pastryCost = 10;
      // }
      else
      {
        return 0;
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

