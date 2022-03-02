using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouBeen.Models;
using System.Collections.Generic;

namespace PlacesYouBeen.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    [TestMethod]

    public void MethodName_Behavior_Type()
    {
      
    }
  
  }
}