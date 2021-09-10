using System.Collections.Generic;
using System;
using Bakery.Models;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryPrice { get; set; } = 2;
    public int PastryAmount { get; set; }

    public Pastry(int pastryAmount)
    {
      PastryAmount = pastryAmount;
    }
  public int FinalPastryPrice()  
  {
    if (PastryAmount % 3 == 0)
    {
      int FinalPastryPrice = (PastryAmount / 3) * 5;
      return FinalPastryPrice;
    }
    else if (PastryAmount % 3 > 0 && PastryAmount >3)
    {
      int FinalPastryPrice = ((PastryAmount / 3) *5) + ((PastryAmount % 3) * PastryPrice);
      return FinalPastryPrice;
    }
    else
    {
      return PastryPrice * PastryAmount;
    }
  }

  }
}