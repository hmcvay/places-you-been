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
      Place newPlace = new Place("test");
      //Assert
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetCityName_ReturnsCiyName_String() 
    {
      //Arrange
      string cityName = "Portland";
      Place newPlace = new Place(cityName);
      //Act
      string result = newPlace.CityName;
      //Assert
      Assert.AreEqual(cityName, result);
    }
  }
}