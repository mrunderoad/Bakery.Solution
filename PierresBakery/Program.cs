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
          Console.WriteLine("Our offers today are fresh Rolls, fresh Scones and fresh Cookies!");
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("How many rolls would you like to purchase?");
          string rollPurchased = Console.ReadLine();
          int BreadNum = int.Parse(rollPurchased);
          if (BreadNum >= 100)
          {
            Console.WriteLine("We have a limit of 99 Rolls per customer. Save some Rolls for the rest of our customers!");
            Start();
          }
          Console.WriteLine("Roll Added to Cart");
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("How many Scones would you like to purchase?");
          string sconePurchased = Console.ReadLine();
          int PastryNum = int.Parse(sconePurchased);
          if (PastryNum >= 100)
          {
            Console.WriteLine("We have a limit of 99 Scones per customer. Save some Scones for the rest of our customers!");
            Start();
          }
          Console.WriteLine("Scone Added to Cart");
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("How many Cookies would you like to purchase?");
          string cookiePurchased = Console.ReadLine();
          int CookieNum = int.Parse(cookiePurchased);
          if (CookieNum >= 200)
          {
            Console.WriteLine("We have a limit of 199 Cookies per customer. Save some Cookies for the rest of our customers!");
          }
          Bread newBread = new Bread(5, BreadNum);
          Pastry newPastry = new Pastry(2, PastryNum);
          Cookie newCookie = new Cookie(3, CookieNum);
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("Here are the items in your cart: ");
          Console.WriteLine($"Rolls: {BreadNum}");
          Console.WriteLine($"Rolls cost: ${newBread.GetBreadCost()}");
          Console.WriteLine($"Scones: {PastryNum}");
          Console.WriteLine($"Scones cost: ${newPastry.GetPastryPrice()}");
          Console.WriteLine($"Cookies: {CookieNum}");
          Console.WriteLine($"Cookies cost: ${newCookie.GetCookieCost()}");
          Console.WriteLine("-----------------------------------");
          Console.WriteLine($"Total cost: ${newBread.GetBreadCost() + newPastry.GetPastryPrice() + newCookie.GetCookieCost()}");
          End();
          }
        else if (check == "N")
        {
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("Sorry we couldnt help you with your Bakery needs. Come back again!");
        }
        static void End()
        {
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("Would you like to place another order? (Y/N)");
          string another = Console.ReadLine().ToUpper();
          if (another == "Y")
          {
            Start();
          }
          else if (another == "N")
          {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Thank you for shopping at Pierres Bakery!");
          }
          else
          {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sorry we didn't catch that. Please type Y or N.");
            End();
          }
        }
    } 
  }
}
