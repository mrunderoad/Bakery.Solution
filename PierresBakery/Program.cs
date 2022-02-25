using System;
using System.Collections.Generic;
using PierresBakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Welcome to Pierres Bakery! Get your fresh bread and pastries here!");
    Start();
      static void Start()
      {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Would you like to get started with an order?(Y/N)");
        string check = Console.ReadLine().ToUpper();
        if (check == "Y")
        {
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("Our offers today are a fresh Roll or a fresh Scone!");
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("How many rolls would you like to purchase?");
          string rollPurchased = Console.ReadLine();
          int BreadNum = int.Parse(rollPurchased);
          Console.WriteLine("Roll Added to Cart");
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("How many Scones would you like to purchase?");
          string sconePurchased = Console.ReadLine();
          int PastryNum = int.Parse(sconePurchased);
          Console.WriteLine("Scone Added to Cart");
          Bread newBread = new Bread(5, BreadNum);
          Pastry newPastry = new Pastry(2, PastryNum);
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("Here are the items in your cart: ");
          Console.WriteLine($"Rolls: {BreadNum}");
          Console.WriteLine($"Rolls cost: ${newBread.GetBreadCost()}");
          Console.WriteLine("-----------------------------------");
          Console.WriteLine($"Scones: {PastryNum}");
          Console.WriteLine($"Scones cost: ${newPastry.GetPastryPrice()}");
          Console.WriteLine("-----------------------------------");
          Console.WriteLine($"Total cost: ${newBread.GetBreadCost() + newPastry.GetPastryPrice()}");
          End();
          }
        else if (check == "N")
        {
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("Sorry we couldnt help you with your Bakery needs. Come back again!");
        }
        static void End()
        {
          Console.WriteLine("Would you like to place another order? (Y/N)");
          string another = Console.ReadLine().ToUpper();
          if (another == "Y")
          {
            Start();
          }
          else if (another == "N")
          {
            Console.WriteLine("Thank you for shopping at Pierres Bakery!");
          }
          else
          {
            Console.WriteLine("Sorry we didn't catch that. Please type Y or N.");
            End();
          }
        }
    } 
  }
}
