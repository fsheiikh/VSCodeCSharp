using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace ninjaGold.Controllers
{   
    public class HomeController : Controller
    {   
        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {   
            if(HttpContext.Session.GetInt32("Total") == null) HttpContext.Session.SetInt32("Total", 0); //check to see if exists, if not set to 0

            ViewBag.total = HttpContext.Session.GetInt32("Total");
            ViewBag.list += HttpContext.Session.GetString("Temp") + "<br>";

            return View();
        }

        [HttpPost]
        [Route("process_money")]
        public IActionResult Method(string building)
        {   
            int temp = getGolds(building);
            setLog(temp); //sets the session string based on each gold increment

            HttpContext.Session.SetInt32("Total", temp + Convert.ToInt32(HttpContext.Session.GetInt32("Total"))); //total = total + temp

            return RedirectToAction("Index");
            
        }

        public int getGolds(string building) 
        {   Random random = new Random();
            if(building == "farm") return random.Next(10, 21);
            else if(building == "cave") return random.Next(5, 11);
            else if(building == "house") return random.Next(2, 6);
            else return random.Next(-50, 51);
        }

        public void setLog(int temp)
        {   
            string log = (temp >= 0) ? 
                String.Format("<h4 class='g'>Earned {0} Golds at " + DateTime.Now + "</h4> ", temp) : 
                String.Format("<h4 class='r'>Lost {0} Golds at " + DateTime.Now + "</h4> ", temp);

            HttpContext.Session.SetString("Temp", HttpContext.Session.GetString("Temp") + "" + log);

        }

        [HttpGet]
        [Route("/reset")]
        public IActionResult Reset()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
