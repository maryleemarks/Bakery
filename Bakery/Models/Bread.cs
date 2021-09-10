 using System.Collections.Generic;
 using System;
 using Bakery.Models;

namespace Bakery.Models
{
  public class Bread
  {
     public int BreadPrice { get; set; } = 5;
    public int BreadAmount { get; set; }

    public Bread(int breadAmount)
    {
      BreadAmount = breadAmount;
    }

  public int FinalBreadPrice()
    {
      int breadSpecial = BreadPrice * ((BreadAmount - (BreadAmount % 3)) / 3);
       int finalBreadPrice = (BreadAmount * BreadPrice) - breadSpecial;
      return finalBreadPrice;
    } 
  }
}