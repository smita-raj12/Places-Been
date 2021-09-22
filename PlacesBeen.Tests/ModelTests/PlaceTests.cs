using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {

    public void Dispose()
    {
      Place.ClearAll();
    }

    [TestMethod]
    public void PlaceConstructor_CreatesInstancesOfPlace_Place()
    {
      Place myPlace = new Place("test", "test");
      Assert.AreEqual(typeof(Place), myPlace.GetType());
    }

    [TestMethod]
    public void GetCityNameAndStayTime_ReturnCityNameAndStayTime_String()
    {
      //Arrange
      string cityName = "Portland";
      string stayTime = "10";
      
      //Act
      Place myPlace = new Place(cityName, stayTime);
      string result1 = myPlace.CityName;
      string result2 = myPlace.StayTime;


      //Assert
      Assert.AreEqual(cityName, result1);
      Assert.AreEqual(stayTime, result2);
    }

    [TestMethod]
    public void SetCityNameAndStayTime_SetCityNameAndStayTime_String()
    {
      //Arrange
      string cityName = "Portland";
      string stayTime = "10";
      Place newPlace = new Place(cityName,stayTime);

      //Act
      string updatedCityName = "Washington";
      string updatedStayTime = "20";
      newPlace.CityName = updatedCityName;
      newPlace.StayTime = updatedStayTime;
      string result1 = newPlace.CityName;
      string result2 = newPlace.StayTime;
      //Assert
      Assert.AreEqual(updatedCityName, result1);
      Assert.AreEqual(updatedStayTime, result2);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      // Arrange
      List<Place> newPlace = new List<Place> { };

      // Act
      List<Place> result = Place.GetAll();

      // Assert
      CollectionAssert.AreEqual(newPlace, result);
    }

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      //Arrange
      string cityName01 = "Portland";
      string cityName02 = "Washington";
      string stayTime01 = " 10 ";
      string stayTime02 = " 20 ";
      Place newPlace1 = new Place(cityName01,stayTime01);
      Place newPlace2 = new Place(cityName02,stayTime01);
      List<Place> newPlace = new List<Place> { newPlace1, newPlace2 };

      //Act
      List<Place> result = Place.GetAll();

      //Assert
      CollectionAssert.AreEqual(newPlace, result);
    }
  }
}