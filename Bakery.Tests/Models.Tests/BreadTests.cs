using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
//using System.Collections.Generic;
//using System;

namespace Bakery.Tests 
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

     [TestMethod]
     public void GetBreadPrice_ReturnsBreadPrice_Int()
     {
       int breadPrice = 5;
       Bread newBread = new Bread(breadPrice);
       int result = newBread.BreadPrice;
       Assert.AreEqual(breadPrice, result);
     }

     [TestMethod]
     public void GetBreadAmount_ReturnsBreadAmount_Int()
     {
       int breadAmount = 1;
       Bread newBread = new Bread(breadAmount);
       int result = newBread.BreadAmount;
       Assert.AreEqual(breadAmount, result);
     }

     [TestMethod]
     public void FinalBreadPrice_ReturnsBradPriceTimesBreadAmount_Int()
     {
       int orderBreadAmount = 1;
       int finalBreadPriceTest = 5;
       Bread newBread = new Bread (orderBreadAmount);
       int finalBreadPrice = newBread.FinalBreadPrice();
       Assert.AreEqual(finalBreadPriceTest, finalBreadPrice);
     }

     [TestMethod]
     public void FinalBreadPrice_ReturnsBreadPriceSpecial_Int()
     {
       int totalBreadAmount = 3;
       int finalBreadPriceTest = 10;
       Bread newBread = new Bread(totalBreadAmount);
       int finalBreadPrice = newBread.FinalBreadPrice();
       Assert.AreEqual(finalBreadPriceTest, finalBreadPrice);
     }


  }
}