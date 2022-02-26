using System;
using PierresBakery.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("------------------------------------------------------------------");
    Console.WriteLine("Welcome to Pierres Bakery! Get your fresh bread and pastries here!");
    Start();
    static void Start()
    {
      Console.WriteLine("---------------------------------------------------------------------------");
      Console.WriteLine("Would you like to get started with an order?(Y/N) Or type S for a surprise!");
      string check = Console.ReadLine().ToUpper();
      if (check == "Y")
      {
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("Our offers today are fresh Rolls, fresh Scones, fresh Cookies and freshly baked Cake!");
        Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("How many rolls would you like to purchase? Rolls are 1 for $5, 2 for $10, 3 for $10(Buy two get one free!). Maximum amount to order is 100.");
        string rollPurchased = Console.ReadLine();
        int BreadNum = int.Parse(rollPurchased);
        if (BreadNum >= 101)
        {
          Console.WriteLine("We have a limit of 100 Rolls per customer. Save some Rolls for the rest of our customers! Please restart your order.");
          Start();
        }
        Console.WriteLine("Rolls Added to Cart!");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("How many Scones would you like to purchase? Scones are 1 for $2, 2 for $3, 3 for $5, 4 for $7, 5 for $9 or 6 for $10. Maximum amount to order is 100.");
        string sconePurchased = Console.ReadLine();
        int PastryNum = int.Parse(sconePurchased);
        if (PastryNum >= 101)
        {
          Console.WriteLine("We have a limit of 100 Scones per customer. Save some Scones for the rest of our customers! Please restart your order.");
          Start();
        }
        Console.WriteLine("Scones Added to Cart!");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("How many Cookies would you like to purchase? Cookies are 1 for $3, 5 for $6 or 10 for $15. Maximum amount to order is 200.");
        string cookiePurchased = Console.ReadLine();
        int CookieNum = int.Parse(cookiePurchased);
        if (CookieNum >= 201)
        {
          Console.WriteLine("We have a limit of 200 Cookies per customer. Save some Cookies for the rest of our customers! Please restart your order.");
          Start();
        }
        Console.WriteLine("Cookies Added to Cart!");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("How many Cakes would you like to purchase? Cakes are 1 for $15 or 3 for $30. Maximum amount to order is 50.");
        string cakePurchased = Console.ReadLine();
        int CakeNum = int.Parse(cakePurchased);
        if (CakeNum >= 51)
        {
          Console.WriteLine("We have a limit of 50 Cakes per customer. Save some Cake for the rest of our customers! Please restart your order.");
          Start();
        }
        Console.WriteLine("Cakes Added to Cart!");
        Bread newBread = new Bread(5, BreadNum);
        Pastry newPastry = new Pastry(2, PastryNum);
        Cookie newCookie = new Cookie(3, CookieNum);
        Cake newCake = new Cake(15, CakeNum);
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Here are the items in your cart: ");
        Console.WriteLine($"Rolls: {BreadNum}");
        Console.WriteLine($"Rolls cost: ${newBread.GetBreadCost()}.00");
        Console.WriteLine($"Scones: {PastryNum}");
        Console.WriteLine($"Scones cost: ${newPastry.GetPastryPrice()}.00");
        Console.WriteLine($"Cookies: {CookieNum}");
        Console.WriteLine($"Cookies cost: ${newCookie.GetCookieCost()}.00");
        Console.WriteLine($"Cakes: {CakeNum}");
        Console.WriteLine($"Cakes cost: ${newCake.GetCakeCost()}.00");
        if (newBread.GetBreadCost() + newPastry.GetPastryPrice() + newCookie.GetCookieCost() + newCake.GetCakeCost() >= 400)
        {
          Console.WriteLine("-----------------------------------------------------------------");
          Console.WriteLine("You're eligable for a half off discount for your order over $400!");
          Console.WriteLine($"Your discounted total cost is: ${newBread.GetBreadCost() + newPastry.GetPastryPrice() + newCookie.GetCookieCost() + newCake.GetCakeCost() % 2}");
          End();
        }
        else
        {
          Console.WriteLine("---------------------");
          Console.WriteLine($"Total cost: ${newBread.GetBreadCost() + newPastry.GetPastryPrice() + newCookie.GetCookieCost() + newCake.GetCakeCost()}.00");
          End();
        }
      }
      else if (check == "N")
      {
        Console.WriteLine("------------------------------------------------------------------");
        Console.WriteLine("Sorry we couldnt help you with your Bakery needs. Come back again!");
        Console.WriteLine("------------------------------------------------------------------");
      }
      else if (check == "S")
      {                                                                                
        Console.Title = "console art";
        string title = @"
           _____ _                           ____        _                   _ 
          |  __ (_)                         |  _ \      | |                 | |
          | |__) |  ___ _ __ _ __ ___  ___  | |_) | __ _| | _____ _ __ _   _| |
          |  ___/ |/ _ \ '__| '__/ _ \/ __| |  _ < / _` | |/ / _ \ '__| | | | |
          | |   | |  __/ |  | | |  __/\__ \ | |_) | (_| |   <  __/ |  | |_| |_|
          |_|   |_|\___|_|  |_|  \___||___/ |____/ \__,_|_|\_\___|_|   \__, (_)
                                                                        __/ |  
                                                                        |___/  
          ";
        Console.WriteLine(title);  
        Start();                      
      }
      else
      {
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Sorry we didn't catch that. Please type Y or N.");
        Start();
      }
      static void End()
      {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Would you like to place another order? (Y/N)");
        string another = Console.ReadLine().ToUpper();
        if (another == "Y")
        {
          Start();
        }
        else if (another == "N")
        {
          Console.WriteLine("-----------------------------------------");
          Console.WriteLine("Thank you for shopping at Pierres Bakery!");
          Console.WriteLine("-----------------------------------------");
        }
        else
        {
          Console.WriteLine("-----------------------------------------------");
          Console.WriteLine("Sorry we didn't catch that. Please type Y or N.");
          End();
        }
      }
    }
  }
}