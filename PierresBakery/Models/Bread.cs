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
      // if (BreadNum >= 0)
      // {
      //   int noDeal = (BreadNum % 3);
      //   int numDeals = (BreadNum - (noDeal))/3;
      //   int getDeals = ((BreadNum - noDeal) - numDeals);
      //   return (getDeals + noDeal) * BreadCost;
      // }
      // else
      // {
      //   return 0;
      // }
      return 7; 
    }    
  }
}