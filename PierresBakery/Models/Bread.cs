using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; }
    public int BreadNum { get; }
    public Bread(int breadPrice, int breadNum)
    {
      BreadPrice = 3;
      BreadNum = breadNum;
    }
    
  }

  
}