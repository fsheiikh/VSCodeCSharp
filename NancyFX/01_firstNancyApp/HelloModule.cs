using Nancy;
using Nancy.Session.Persistable;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;
using Nancy.Session.InMemory;
namespace HelloNancy
{
    public class HelloModule : NancyModule
    {   
        public string User {get; set;}
        

        public HelloModule()
        {
            //Get("/", args => "Hello Nancy!");
            //Get("/", args => "Hllo world!");
            // Post("/template", args => 
            // {
            // return Response.AsRedirect("/");
            // });
           
           

            Get("/", args =>
            {
                Session["SomeName"] = "Some stuff!";
                ViewBag.x = Session["SomeName"];
            
            
            return View["Hello.sshtml"];
            });

            Post("/formsubmitted", args =>
            {
                //string User = Request.Form.Username;
                //OR
                User = Request.Form["Username"];
                System.Console.WriteLine(User);
                ViewBag.x = User;
                Session["SomeName"] = "e stuff!";
                return View["Hello.sshtml"];
                //return Response.AsRedirect("/");
            });


            Get("/{name}", args => $"Hello {args.name}!");
        }

        
    }
}