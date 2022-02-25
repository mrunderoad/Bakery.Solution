using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadCost { get; }
    public int BreadNum { get; }
    public Bread(int breadCost, int breadNum)
    {
      BreadCost = 5;
      BreadNum = breadNum;
    }

    public int GetBreadCost()
    {
      int BreadCost = 5;

      if (BreadNum == 1)
      {
        BreadCost = 5;
      }
      else if (BreadNum == 2)
      {
        BreadCost = 10;
      }
      else if (BreadNum == 3)
      {
        BreadCost = 10;
      }
      else
      {
        return BreadNum * 5;
      }
      return BreadCost;
    }    
  }
}