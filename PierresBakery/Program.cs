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
        Console.WriteLine("Would you like to get started with an order?(Y/N) Or view your current order(View)");
        string check = Console.ReadLine().ToUpper();

        if (check == "Y")
        {
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("Our offers today are a fresh Roll or a fresh Scone!");
          Console.WriteLine("What sounds better today?(Bread/Pastry) Or view your cart!(View)");
          string option = Console.ReadLine().ToUpper();
          if (option == "BREAD")
          {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("How many rolls would you like to purchase?");
            string rollPurchased = Console.ReadLine();
            int BreadNum = int.Parse(rollPurchased);
            Console.WriteLine("Roll Added to Cart");
            Start();
          }
          else if (option == "PASTRY") 
          {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("How many Scones would you like to purchase?");
            string sconePurchased = Console.ReadLine();
            int PastryNum = int.Parse(sconePurchased);
            Console.WriteLine("Scone Added to Cart");
            Start();
          }
          else if (option == "VIEW")
          {
            Bread newBread = new Bread(5, BreadNum);
            Pastry newPastry = new Pastry(2, PastryNum);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Here are the items in your cart: ");
            Console.WriteLine($"Roll Quantity: {BreadNum}");
            Console.WriteLine($"Scone Quantity: {PastryNum}");
          }
          else 
          {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sorry! We're only offering Rolls and Scones today.");
            Start();
          }
         }
        else if (check == "N")
        {
          Console.WriteLine("-----------------------------------");
          Console.WriteLine("Sorry we couldnt help you with your Bakery needs. Come back again!");
         }
    } 
  }
}
