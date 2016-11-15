using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DapperApp.Models;
using DapperApp.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;


namespace DapperApp.Controllers
{
    public class HomeController : Controller
    {
        // private readonly UserRepository userRepository;

        // public HomeController(UserRepository user) {
        //     userRepository = user;
        // }

        // GET: /Home/
        // [HttpGet]
        // [Route("")]
        // public IActionResult Index()
        // {
        //     return View("Index", userRepository.FindAll());
        // }

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        // [RouteAttribute("new")]
        // public IActionResult New(User newUser)
        // {
        //     userRepository.Add(newUser);
        //     return RedirectToAction("Index");
        // }

        //Route
        //  public IActionResult Method(User user)
        // {
        //     if(ModelState.IsValid)
        //     {
        //         PasswordHasher<User> Hasher = new PasswordHasher<User>();
        //         user.Password = Hasher.HashPassword(user, user.Password);
        //         //Save your user object to the database
        //     }
        // }

        //Route
        // public IActionResult LoginMethod(string Email, string Password)
        // {
        //     //Attempt to retrieve a user from your database based on the Email submitted
        //     if(user != null && Password != null)
        //     {
        //         var Hasher = new PasswordHasher<User>();
        //         if(0 != Hasher.VerifyHashedPassword(user, user.Password, Password))
        //         {
        //             //Handle success
        //         }
        //     }
        //     //Handle failure
        // }

        // private readonly LoginRepository loginRepository;

        // public LoginController(LoginRepository login) {        
        //     loginRepository = login;
        // }

        // // GET: /Home/
        // [HttpGet]
        // [Route("/")]
        // public IActionResult Index()
        // {   
           
        //     ViewBag.Errors = new List<string>();
        //     return View("registration");
        // }

        // [HttpPost]
        // [Route("register")]
        // public IActionResult New(User user)
        // {   
        //     if(ModelState.IsValid)
        //     {
        //         PasswordHasher<User> Hasher = new PasswordHasher<User>();
        //         user.password = Hasher.HashPassword(user, user.password);
        //         TryValidateModel(user);
        //         loginRepository.Add(user);

        //         //Save your user object to the database
        //         return View("login");
        //     }
        //     ViewBag.Errors = ModelState.Values;
        //     return View("registration");//error goes back to page with errors
        // }

        // [HttpGet]
        // [Route("login")]
        // public IActionResult loginpage()
        // {   
        //     return View("login");
        // }


        // [HttpPost]
        // [Route("login")]
        // public IActionResult LoginMethod(string Email, string PasswordToCheck)
        // {
        //     // Attempt to retrieve a user from your database based on the Email submitted
        //     User user = loginRepository.FindByEmail(Email);

        //     System.Console.WriteLine(user);
            
        //     if(user != null && user.password != null)
        //     {
        //         var Hasher = new PasswordHasher<User>();

        //         // Pass the User object, the hashed password, and the password to check
        //         if(0 != Hasher.VerifyHashedPassword(user, user.password, PasswordToCheck))
        //         {
        //             //Handle success
        //             ViewBag.user = loginRepository.FindByEmail(Email);
        //             HttpContext.Session.SetInt32("id", (int)user.Id);
        //             TempData["Variable"] = "Success!";
        //             return View("userpage");

        //         }
        //     }
        //     //Handle failure
        //     TempData["Variable"] = "Failed";

        //      return View("userpage");
        // }
    }
}
