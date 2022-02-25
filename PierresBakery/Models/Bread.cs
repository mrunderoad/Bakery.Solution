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
        return BreadCost = 5;
      }
      else if (BreadNum == 2)
      {
        return BreadCost = 10;
      }
      else if (BreadNum == 3)
      {
        return BreadCost = 10;
      }
      else
      {
        return BreadNum * 5;
      }
      
    }    
  }
}