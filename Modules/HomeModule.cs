using Nancy;
using Places.Objects;
using System.Collections.Generic;

namespace Places
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        if (Place.Counter > 0) {
          return View["places.cshtml", Place.GetList()];
        }
        else
        {
          return View["index.cshtml"];
        }

      };
      Post["/add-place"] = _ => {
        Place newPlace = new Place(Request.Form["city"], Request.Form["country"], Request.Form["season"]);
        return View["confirmation.cshtml"];
      };
    }
  }
}
