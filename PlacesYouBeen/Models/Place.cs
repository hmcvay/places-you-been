using System.Collections.Generic;

namespace PlacesYouBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    // public string Date { get; set; }
    private static List<Place> _instances = new List<Place> {};
    public Place(string cityName) 
    {
      CityName = cityName;
      // Date = date;
      _instances.Add(this);
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll() {
    _instances.Clear();
    }
  }
}