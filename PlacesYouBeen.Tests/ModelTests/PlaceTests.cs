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
      Place newPlace = new Place("test city","test date");
      //Assert
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetCityName_ReturnsCiyName_String() 
    {
      //Arrange
      string cityName = "Portland";
      // string date = "Jan 1, 2022";
      Place newPlace = new Place(cityName, "date");
      //Act
      string result = newPlace.CityName;
      //Assert
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String() 
    {
      //Arrange
      string cityName = "Portland";
      string date = "Jan 1, 2022";
      Place newPlace = new Place(cityName, date);
      //Act
      string result = newPlace.Date;
      //Assert
      Assert.AreEqual(date, "Test");
    }
  }
}