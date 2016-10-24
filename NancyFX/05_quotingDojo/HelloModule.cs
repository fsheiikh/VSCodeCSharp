using Nancy;
using DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {

            Get("/", args =>
            {
                //Session["SomeName"] = "Some stuff!";
                ViewBag.AllQuotes = Query.selectAll();
                return View["Hello.sshtml"];
            });

            
            

            Post("/quote", args =>
            {
                Query.insertQuote(Request.Form.name, Request.Form.comment);
                return Response.AsRedirect("/");
            });
        }
    }
}