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

        // // GET: /Home/
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
    }
}
