using Nancy;
namespace HelloNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get("/HelloWorld", args => "Hello world!");

            Get("/", args =>
            {
                Session["SomeName"] = "Some stuff!";
                ViewBag.x = Session["SomeName"];
            return View["Hello.sshtml"];
            });
            
            // Post("/template", args => 
            // {
            // return Response.AsRedirect("/");
            // });

            Post("/formsubmitted", args =>
            {
                //string User = Request.Form.Username;
                //OR
                string User = Request.Form["Username"];
                return User;
            });
        }
    }
}