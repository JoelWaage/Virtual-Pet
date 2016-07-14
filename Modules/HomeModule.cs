using Nancy;
using VirtualPet.Objects;
using System.Collections.Generic;
using System;

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
        string TamName = Request.Form["tam-name"];
        Tam newTam = new Tam(TamName, 50, "is", "a", "test");
        // newTam.Save();
        return View["tam_home.cshtml", newTam];
      };
      Post["/tam_play"] = _ => {
        int tamId = Request.Form["tam-id"];
        Tam thisTam = Tam.Find(tamId);
        return View["tam_home.cshtml", thisTam];
      };
    }
  }
}
