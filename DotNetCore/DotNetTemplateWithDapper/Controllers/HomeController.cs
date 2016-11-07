using System;
using System.Collections.Generic;
using quotingdojo.Models;
using Microsoft.AspNetCore.Mvc;
using quotingdojo.Factory; //Need to include reference to new Factory Namespace
namespace quotingdojo.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserFactory userFactory;
        public HomeController()
        {
            //Instantiate a UserFactory object that is immutable (READONLY)
            //This is establish the initial DB connection for us.
            userFactory = new UserFactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //We can call upon the methods of the userFactory directly now.
            ViewBag.Users = userFactory.FindAll();
            return View();
        }
    }
}