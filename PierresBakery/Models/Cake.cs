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
  }
}