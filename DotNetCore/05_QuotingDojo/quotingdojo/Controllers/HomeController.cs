using System;
using System.Collections.Generic;
using quotingdojo.Models;
using Microsoft.AspNetCore.Mvc;
using quotingdojo.Factory; //Need to include reference to new Factory Namespace

namespace quotingdojo.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuoteFactory quoteFactory;
        public HomeController()
        {
            //Instantiate a UserFactory object that is immutable (READONLY)
            //This is establish the initial DB connection for us.
            quoteFactory = new QuoteFactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //We can call upon the methods of the userFactory directly now.
            ViewBag.Quotes = quoteFactory.FindAll();
            return View();
        }

        [HttpPost]
        [Route("quote")]
        public IActionResult addQuote(Quote newQuote)
        {   
            quoteFactory.Add(newQuote);
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [Route("quotes/delete/{id}")]
        public IActionResult addQuote(int id)
        {   
            quoteFactory.DeleteByID(id);
            return RedirectToAction("Index");
        }
    }
}
