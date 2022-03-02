using System.Collections.Generic;

namespace PlacesYouBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    public string Date { get; set; }
    //  private static List<Item> _instances = new List<Item> {};
    public Place(string cityName, string date) 
    {
      CityName = cityName;
      Date = date;
      // _instace.Add(this);
    }
  }
}