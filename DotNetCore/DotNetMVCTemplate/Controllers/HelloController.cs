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
   //return View("Index");

  }

  [HttpPost]
  [Route("method")]
  public IActionResult Method(string TextField, int NumberField)
  {
    System.Console.WriteLine(TextField + "" + NumberField);

    return View("Index");
  }

 }

    // TempData["Variable"] = "Hello World";

    // HttpContext.Session.SetString("Key", "Value");
    // ...
    // HttpContext.Session.GetString("Key");
    // ...
    // HttpContext.Session.SetInt32("OtherKey", 123);
    // ...
    // HttpContext.Session.GetInt32("OtherKey");

    // HttpContext.Session.Clear();




    //examples of redirecting
    // public IActionResult Method()
    // {
    // return RedirectToAction("OtherMethod", new {parameter = "this is a string"});
    // }

    // [HttpGet]
    // [Route("other/{parameter}")]
    // public IActionResult OtherMethod(string parameter)
    // {
    
    // }

    // public IActionResult Method()
    // {
    // return RedirectToAction("OtherMethod", "OtherController", new {parameter = "this is a string"});
    // }
}