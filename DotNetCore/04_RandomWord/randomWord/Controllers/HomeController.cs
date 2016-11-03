using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace randomWord.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {   
            ViewBag.word = TempData["Word"];
            return View();
        }

        [HttpPost]
        [Route("generate")]
        public IActionResult getRandomWord()
        {
            TempData["Word"] = RandomWord.name();
           return RedirectToAction("Index");
        }
    }
}
