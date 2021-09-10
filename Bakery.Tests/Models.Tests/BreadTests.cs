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
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    // [TestMethod]
    // public void GetBreadPrice_ReturnsBreadPrice_Int()
    // {
    //   int breadPrice = 5;
    //   Bread newBread = new Bread(breadPrice);
    //   int result = newBread.BreadPrice;
    //   Assert.AreEqual(breadPrice, result);
    // }

  }
}