using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlacesYouBeen.Models;
using System.Collections.Generic;

namespace PlacesYouBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceConstructor_CreateInstanceOfPlace_Place()
    {
      //Arrange
      Place newPlace = new Place("test city");
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

    // [TestMethod]
    // public void GetDate_ReturnsDate_String() 
    // {
    //   //Arrange
    //   string cityName = "Portland";
    //   string date = "Jan 1, 2022";
    //   Place newPlace = new Place(cityName);
    //   //Act
    //   string result = newPlace.Date;
    //   //Assert
    //   Assert.AreEqual(date, "Test");
    // }

    [TestMethod]
    public void GetAll_ReturnAllCityNames_PlaceList()
    {
      //Arrange
      string city1 = "City1";
      string city2 = "City2";
      Place place1 = new Place(city1);
      Place place2 = new Place(city2);
      List<Place> placeList = new List<Place> { 
        place1, place2 
      };
      //Act
      List<Place> resultList = Place.GetAll();
      //Assert
      CollectionAssert.AreEqual(placeList, resultList);
    }
  }
}