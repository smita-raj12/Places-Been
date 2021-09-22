using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Place
  {
    public string CityName {get; set;}
    public string StayTime {get; set;}
    private static List<Place> _instances = new List<Place>{ };
    
    public Place(string cityName, string stayTime)
    {
      CityName = cityName;
      StayTime = stayTime;
      _instances.Add(this);
    }
    
    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    // public static Item Find(int searchId)
    // {
    //   return _instances[searchId - 1];
    // }
  }
}