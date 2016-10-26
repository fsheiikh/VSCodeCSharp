using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;


namespace YourNamespace.Controllers
{
 public class SurveyController : Controller
 {
  [HttpGet]
  [Route("/")]
  public IActionResult Index()
  {
  

   return View();
   //OR
   return View("Index");

  }

  [HttpPost]
  [Route("survey")]
  public IActionResult Method(string Name, string Location, string Language, string Comment)
  {

    List<string> surveyResults = new List<string>();
    surveyResults.Add("Name: " + Name);
    surveyResults.Add("Location: " + Location);
    surveyResults.Add("Language: " + Language);
    surveyResults.Add("Comment: " + Comment);
    
    ViewBag.surveyResults = surveyResults;

    return View("Survey");
  }

 }
}