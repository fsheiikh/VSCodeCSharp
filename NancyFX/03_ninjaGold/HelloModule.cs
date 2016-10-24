using Nancy;
namespace HelloNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {


            Get("/", args =>
            {
            Session["Total"] = Gold.getTotalGold();
            ViewBag.Total = Session["Total"];

            ViewBag.Temp = Session["Temp"];
            ViewBag.Temp = Gold.setGolds(ViewBag.Temp);
            
            return View["Hello.sshtml"];
            });


            Post("/process_money", args =>
            {   
                Session["Temp"] = Gold.checkBuilding(Request.Form["building"]);
                return Response.AsRedirect("/");
            });

            Post("/reset", args =>
            {   
                Session["Temp"] = 0;
                Gold.reset();
                return Response.AsRedirect("/");
            });
        }
    }
}