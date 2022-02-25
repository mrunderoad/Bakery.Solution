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
      PastryCost = 4;
      PastryNum = pastryNum;
    }
  }
}