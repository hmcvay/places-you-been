using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouBeen.Models;
// using System.Collections.Generic;

namespace PlacesYouBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
  public void PlaceConstructor_CreateInstanceOfPlace_Place()
  {
    //Arrange
    Place newPlace = new Place();
    //Assert
    Assert.AreEqual(typeof(Place), newPlace.GetType());
  }
  }
  
}