 using System.Collections.Generic;
 using System;
 using Bakery.Models;

 namespace Bakery
 {
   public class Program
   {

      public static void Main()
     {
      Console.WriteLine("Welcome to the Bakery!");
      Console.WriteLine("Check out our Menu and Specials");
      Console.WriteLine("Bread: $5 per loaf or buy 2 get 1 free!");
      Console.WriteLine("Pastries: $2 per Pastry or 3 Pastries for $5!");
      Console.WriteLine("How many loaves of bread would you like?");
      string stringBreadAmount = Console.ReadLine();
      int BreadAmount = int.Parse(stringBreadAmount);
      Console.WriteLine("How many pastries would you like?");
      string stringPastryAmount = Console.ReadLine();
      int PastryAmount = int.Parse(stringPastryAmount);
      Bread orderBread = new Bread(BreadAmount);
      Pastry orderPastry = new Pastry(PastryAmount);
      int finalPrice = orderBread.FinalBreadPrice() + orderPastry.FinalPastryPrice();
      Console.WriteLine("Your order is $" + finalPrice);
      }
    }
   }