using Nancy;
using ParcelShipping.Objects;

namespace ParcelProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["order-form.cshtml"];
      };

      Get["/dimensions"] = _ => {
        int length = (Request.Query["length"]);
        int width = (Request.Query["width"]);
        int weight = (Request.Query["weight"]);
        ParcelPrice myParcelPrice = new ParcelPrice(length, width, weight);
        return View["cost-page.cshtml", myParcelPrice];
      };

    }
  }
}
