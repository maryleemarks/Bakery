using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests 
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

     [TestMethod]
     public void GetPastryPrice_ReturnsPastryPrice_Int()
     {
       int pastryPrice = 2;
       Pastry newPastry = new Pastry(pastryPrice);
       int result = newPastry.PastryPrice;
       Assert.AreEqual(pastryPrice, result);
     }

     [TestMethod]
     public void GetPastryAmount_ReturnsPastryAmount_Int()
     {
       int pastryAmount = 1;
       Pastry newPastry = new Pastry(pastryAmount);
       int result = newPastry.PastryAmount;
       Assert.AreEqual(pastryAmount, result);
     }

     [TestMethod]
     public void FinalPastryPrice_ReturnsPastryPriceTimesPastryAmount_Int()
     {
       int orderPastryAmount = 1;
       int finalPastryPriceTest = 2;
       Pastry newPastry = new Pastry (orderPastryAmount);
       int finalPastryPrice = newPastry.FinalPastryPrice();
       Assert.AreEqual(finalPastryPriceTest, finalPastryPrice);
     }

     [TestMethod]
     public void FinalPastryPrice_ReturnsPastryPriceSpecial_Int()
     {
       int totalPastryAmount = 3;
       int finalPastryPriceTest = 5;
       Pastry newPastry = new Pastry(totalPastryAmount);
       int finalPastryPrice = newPastry.FinalPastryPrice();
       Assert.AreEqual(finalPastryPriceTest, finalPastryPrice);
     }


  }
}