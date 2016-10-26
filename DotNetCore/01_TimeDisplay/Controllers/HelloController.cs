using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace YourNamespace.Controllers
{
 public class HelloController : Controller
 {
  [HttpGet]
  [Route("/")]
  public IActionResult Index()
  {
   ViewBag.x = DateTime.Now;
   return View();
   //OR
   return View("Index");
   //Both of these returns will render the same view
  }
 }
}