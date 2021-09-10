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

  }
}