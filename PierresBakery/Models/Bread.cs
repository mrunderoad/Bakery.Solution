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

    public int GetBreadCost(int BreadNum)
    {
      if (BreadNum >= 3)
      {
        BreadNum = (BreadNum / 3) * 2 + BreadNum % 3;
      }
      return BreadNum * 5;
    }    
  }
}