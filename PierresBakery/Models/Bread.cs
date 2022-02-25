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
      BreadCost = 3;
      BreadNum = breadNum;
    }
    
  }

  
}