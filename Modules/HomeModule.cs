using Nancy;
using VirtualPet.Objects;
using System.Collections.Generic;

namespace VirtualPet
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/tam_home"] = _ => {
        Tam newTam = new Tam(Request.Form["tam-name"], 50, "is", "a", "test");
        return View["tam_home.cshtml", newTam];
      };
    }
  }
}
