using Nancy;
using ApiCaller;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloNancy
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
         

            Post("/formsubmitted", args =>
            {
                string id = Request.Form["PokemonID"];
                Pokemon.setID(id);
                return Response.AsRedirect("/");
            });

            Get("/", async args =>
            {
                object Name = "", Weight = 0, Height = 0.0;
                
                Session["URl"] = Pokemon.getUrl();
                
                
                await WebRequest.SendRequest((string)Session["URl"], new Action<Dictionary<string, object>>( JsonResponse =>
                    {
                        Name = JsonResponse["name"];
                        Weight = JsonResponse["weight"];
                        Height = JsonResponse["height"];
                        //Type = (object[])JsonResponse["types"];
                    }
                ));
                Console.WriteLine(Name); // bulbasaur

                ViewBag.pokemonName = Name;
                ViewBag.pokemonWeight = Weight;
                ViewBag.pokemonHeight = Height;
               // ViewBag.pokemonType = Type;
                //System.Console.WriteLine(Type);

                ViewBag.pokemonSprite = Pokemon.getImage();

                return View["Hello.sshtml"];
            });
            
        }
    }
}