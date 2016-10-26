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
   List<string> listOfStrings = new List<string>();
       listOfStrings.Add("Item1");
       listOfStrings.Add("Item2");
       listOfStrings.Add("Item3");


   ViewBag.list = listOfStrings;

   return View();
   //OR
   return View("Index");

  }

  [HttpPost]
  [Route("method")]
  public IActionResult Method(string TextField, int NumberField)
  {
    System.Console.WriteLine(TextField + "" + NumberField);

    return View("Index");
  }

 }
}