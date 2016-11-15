using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DapperApp.Models;
using DapperApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;



namespace DapperApp.Controllers
{
    public class QuoteController : Controller
    {
        private readonly QuoteRepository quoteRepository;
         private readonly UserRepository userRepository;

        public QuoteController(QuoteRepository quote, UserRepository user) {         
            quoteRepository = quote;
            userRepository = user;
        }
       

       [HttpGet]
       [Route("quotes")]
       public IActionResult Quotes()
       {   
           ViewBag.Errors = new List<string>();
           var quotes = quoteRepository.FindAll();

           foreach(var q in quotes)
           {    
               q.user = userRepository.FindByID(q.user_id);
               System.Console.WriteLine(q.user.name);
           }

           
           ViewBag.quotes = quotes;

            ViewBag.ID = (int)HttpContext.Session.GetInt32("id");
           return View();
       }

       [HttpPost]
       [Route("addquote")]
       public IActionResult AddQuotes(Quote q)
       {       
           if(ModelState.IsValid)
            {
                TryValidateModel(q);
                q.user_id = (int)HttpContext.Session.GetInt32("id");
                quoteRepository.Add(q);
                
                //Save your user object to the database
                ViewBag.quotes = quoteRepository.FindAll();
                return View("quotes");
            }

            ViewBag.ID = (int)HttpContext.Session.GetInt32("id");
            ViewBag.quotes = quoteRepository.FindAll();
            ViewBag.Errors = ModelState.Values;
            return View("quotes");


       }

        [HttpPost, ActionName("Delete")]
        [Route("quotes/delete/{id}")]
        public IActionResult addQuote(int id)
        {   
            quoteRepository.DeleteByID(id);
            return RedirectToAction("Quotes");
        }
        

    }
}
