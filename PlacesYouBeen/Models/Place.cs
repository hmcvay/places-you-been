using System.Collections.Generic;

namespace PlacesYouBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    //  private static List<Item> _instances = new List<Item> {};
    public Place(string cityName) 
    {
      CityName = cityName;
      // _instace.Add(this);
    }
  }
}