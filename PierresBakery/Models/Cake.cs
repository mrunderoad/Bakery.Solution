namespace PierresBakery.Models
{
  public class Cake{
    public int CakeCost { get; }
    public int CakeNum { get; }
    public Cake(int cakeCost, int cakeNum)
    {
      CakeCost = 15;
      CakeNum = cakeNum;
    }

    public int GetCakeCost()
    {
      int CakeCost = 15;

      if (CakeNum == 1)
      {
        CakeCost = 15;
      }
      else if (CakeNum == 3)
      {
        CakeCost = 30;
      }
      else
      {
        return CakeNum * 15;
      }
      return CakeCost;
    }
  }
}