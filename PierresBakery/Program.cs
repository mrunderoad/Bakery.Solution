using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Welcome to Pierres Bakery! Get your fresh bread and pastries here!");
      Start();

        static void Start()
        {
        Console.WriteLine("Would you like to get started with an order?(Y/N) Or view your current order(View)");
        string check = Console.ReadLine().ToUpper();

        if (check == "Y")
        {
          Console.WriteLine("Our offers today are a fresh Roll or a fresh Scone!");
          Console.WriteLine("What sounds better today?(Bread/Pastry)");
          string option = Console.ReadLine().ToUpper();
          if (option == "BREAD")
          {
            Console.WriteLine("How many rolls would you like to purchase?");
            string rollPurchased = Console.ReadLine();
            int roll = int.Parse(rollPurchased);
            //add to cart
            Console.WriteLine("Roll Added to Cart");
          }
          else if (option == "PASTRY") 
          {
            Console.WriteLine("How many Scones would you like to purchase?");
            string sconePurchased = Console.ReadLine();
            int scone = int.Parse(sconePurchased);
            //add to cart
            Console.WriteLine("Scone Added to Cart");
          }
          else 
          {
            Console.WriteLine("Sorry! We're only offering Rolls and Scones today.");
          }
        }
      } 
    }
  }
}