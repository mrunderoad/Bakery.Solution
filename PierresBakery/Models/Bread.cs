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
      int breadCost = 5;

      if (BreadNum == 1)
      {
        return breadCost = 5;
      }
      else if (BreadNum == 2)
      {
        return breadCost = 10;
      }
      else if (BreadNum == 3)
      {
        return breadCost = 10;
      }
      else
      {
        return BreadNum * 5;
      }
      
    }    
  }
}