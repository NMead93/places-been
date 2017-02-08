using System.Collections.Generic;

namespace Places.Objects
{
  public class Place
  {
    public string City {get;set;}
    public string Country {get;set;}
    public string Season {get;set;}
    private static List<Place> _instances = new List<Place> {};
    public static int Counter = 0;


    public Place(string city, string country, string season)
    {
      City = city;
      Country = country;
      Season = season;
      _instances.Add(this);
      Counter++;
    }

    public static List<Place> GetList()
    {
      return _instances;
    }

  }
}
