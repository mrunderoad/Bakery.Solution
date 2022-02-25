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

      if (PastryNum == 2)
      {
        return pastryCost = 3;
      }
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

