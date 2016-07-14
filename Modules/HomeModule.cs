using Nancy;
using System.Collections.Generic;
using CDOrganizer.Objects;

namespace CDOrganizer
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/cds"] = _ => {
        List<CompactDisk> allCds = CompactDisk.GetAll();
        return View["cds.cshtml", allCds];
      };

      Get["/cds/new"] = _ =>
      {
        return View["cd_form.cshtml"];
      };

      Post["/cds"] = _ =>
      {
        CompactDisk myNewCD = new CompactDisk(Request.Form["cd-title"], Request.Form["cd-artist"]);
        return View["cds.cshtml", myNewCD];
      };

    }
  }
}
