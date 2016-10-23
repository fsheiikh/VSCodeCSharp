using Nancy;
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
                
                Session["Number"] = Random.getRandom();
                ViewBag.currentNumber = Session["Number"] ;
                ViewBag.msg = Session["Message"];
                return View["Hello"];
            });
            

            Post("/guess", args =>
            {
                string guess = Request.Form["Number"];
                Session["Message"] = Random.checkGuess(guess);
                Session["Number"] = Random.getRandom();
                ViewBag.currentNumber= Session["Number"] ;
                ViewBag.msg = Session["Message"];

                //return View["Hello"];
                return Response.AsRedirect("/");
            });

        }
    }
}